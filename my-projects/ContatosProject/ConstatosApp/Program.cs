// See https://aka.ms/new-console-template for more information
using System.Text.Json;
//using System.Environment;

namespace ConstatosApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Contato> contatos = new List<Contato>();
            //          Console.WriteLine(Environment.CurrentDirectory);
            //            Console.WriteLine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData));
            //            Console.WriteLine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
            //          Console.WriteLine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData));
            //        var separator = System.IO.Path.PathSeparator;
            //string dataFilePath = "./workspace/csharp-hunt/my-projects/ContatosProject/ConstatosApp/data.json";
            string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string appDataDir = "andrevContatos";
            string dataFilePath = Path.Combine(appDataPath, appDataDir, "data.json");
            //Console.WriteLine(dataFilePath);
            Directory.CreateDirectory(Path.Combine(appDataPath, appDataDir));
            //Console.WriteLine(Path.Combine(appDataPath, appDataDir));



            if (File.Exists(dataFilePath))
            {
                string fileContent = File.ReadAllText(dataFilePath);
                List<Contato> loadedContacts = JsonSerializer.Deserialize<List<Contato>>(fileContent);
                foreach (Contato contato in loadedContacts)
                {
                    contatos.Add(contato);
                }

            }

            int userOption = 0;
            do
            {

                ShowMenu();
                userOption = int.Parse(Console.ReadLine());

                switch (userOption)
                {
                    case 1:
                        AddContact();
                        break;
                    case 2:
                        GetAllContacts();
                        break;
                    case 3:
                        GetContact();
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                }


            } while (userOption != 5);


            var data = JsonSerializer.Serialize(contatos);
            File.WriteAllText(dataFilePath, data);

            Console.WriteLine("Obrigado por usar andrev agenda");


            void ShowMenu()
            {
                Console.WriteLine("*************************************");
                Console.WriteLine("andrev agenda, seja bem vindo!");
                Console.WriteLine("Escolha uma opção do menu abaixo:");
                Console.WriteLine();
                Console.WriteLine("1 - Adicionar novo contato");
                Console.WriteLine("2 - Listar contatos");
                Console.WriteLine("3 - Buscar contato");
                Console.WriteLine("4 - Remover contato");
                Console.WriteLine("5 - Sair do programa");
                Console.WriteLine();
                Console.WriteLine("*************************************");
            }

            void GetContact()
            {
                Console.WriteLine("Vamos buscar um contato");
                Console.WriteLine("Por favor, digite o nome, o email ou o id do contato");
                var userInput = Console.ReadLine();
                var result = contatos.Single(c => c.FirstName == userInput);
                Console.Write($"{result.Id}\t{result.FullName}\t {result.Email}");
            }

            void AddContact()
            {

                Console.WriteLine("Certo, vamos adicionar um novo contato!");
                Contato contato = new Contato();
                Endereco endereco = new Endereco();
                int id = contatos.Count + 1;
                endereco.Id = id;
                contato.Id = id;

                Console.WriteLine("Primeiro me fala, qual o nome do contato?");
                var fName = Console.ReadLine();
                contato.FirstName = fName;
                do
                {
                    Console.WriteLine("Nome invalid, tent novamente");
                    var _fName = Console.ReadLine();
                    contato.FirstName = _fName;

                } while (!contato.FirstNamIsValid());


                Console.WriteLine("E o sobrenome?");
                var lName = Console.ReadLine();
                contato.LastName = lName;

                contato.FullName = $"${contato.FirstName} {contato.LastName}";

                Console.WriteLine("Qual o email do contato?");
                var email = Console.ReadLine();
                contato.Email = email;
                do
                {
                    Console.WriteLine("invalid email, try again");
                    var _email = Console.ReadLine();
                    contato.Email = _email;
                } while (!contato.EmailIsValid());

                Console.WriteLine("Qual o telefone do contato?");
                var phone = Console.ReadLine();
                contato.Phone = phone;

                Console.WriteLine("Qual a cidade?");
                var city = Console.ReadLine();
                endereco.Cidade = city;
                Console.WriteLine("Qual o estado?");

                var uf = Console.ReadLine();
                endereco.Estado = uf;
                Console.WriteLine("Qual o bairro?");
                var province = Console.ReadLine();
                endereco.Bairro = province;

                Console.WriteLine("Qual a rua?");
                var streetName = Console.ReadLine();
                endereco.Rua = streetName;
                Console.WriteLine("Qual o número a residência?");
                int streetNumber = int.Parse(Console.ReadLine());
                endereco.Numero = streetNumber;

                contato.Endereco = endereco;
                contatos.Add(contato);
                Console.WriteLine($"Contato {contato.FullName} foi adicionado com sucesso");

            }


            void GetAllContacts()
            {
                Console.WriteLine("Contatos:");
                foreach (Contato contato in contatos)
                {
                    Console.WriteLine($"{contato.Id}\t{contato.FullName}\t{contato.Email}");
                }
            }

        }
    }
}

