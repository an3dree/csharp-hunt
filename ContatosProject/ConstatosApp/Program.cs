// See https://aka.ms/new-console-template for more information
using System.Text.Json;
//using System.Environment;

namespace ConstatosApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //            List<Contato> contatos = new List<Contato>();
            string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string appDataDir = "andrevContatos";
            string dataFilePath = Path.Combine(appDataPath, appDataDir, "data.json");
            Directory.CreateDirectory(Path.Combine(appDataPath, appDataDir));
            Service service = new Service();

            if (File.Exists(dataFilePath))
            {
                string fileContent = File.ReadAllText(dataFilePath);
                List<Contato> loadedContacts = JsonSerializer.Deserialize<List<Contato>>(fileContent);
                service.LoadContacts(loadedContacts);

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
                        EditContact();
                        break;
                    case 5:
                        RemoveContact();
                        break;
                    case 6:
                        break;
                }


            } while (userOption != 6);

            List<Contato> contatos = service.GetContacts();
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
                Console.WriteLine("4 - Editar contato");
                Console.WriteLine("5 - Remover contato");
                Console.WriteLine("6 - Sair do programa");
                Console.WriteLine();
                Console.WriteLine("*************************************");
            }

            void GetContact()
            {
                Console.WriteLine();
                Console.WriteLine("Vamos buscar um contato");
                Console.WriteLine("Por favor, digite o nome ou o id do contato");
                var userInput = Console.ReadLine();
                var result = service.GetContato(userInput);
                Console.Write($"{result.Id}\t{result.Name}\t {result.Email}");
            }

            void AddContact()
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("___________________________________________________");

                Console.WriteLine("Certo, vamos adicionar um novo contato!");
                //                Contato contato = new Contato();
                Endereco endereco = new Endereco();
                int id = service.GetContacts().Count + 1;
                endereco.Id = id;

                Console.WriteLine("Primeiro me fala, qual o nome do contato?");
                var fName = Console.ReadLine();

                Console.WriteLine("E o sobrenome?");
                Console.WriteLine("Qual o email do contato?");
                var email = Console.ReadLine();
                Console.WriteLine("Qual o telefone do contato?");
                var phone = Console.ReadLine();

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
                string streetNumber = Console.ReadLine();
                endereco.Numero = streetNumber;

                Contato contato = new Contato
                {
                    Id = id,
                    Name = fName,
                    Email = email,
                    Phone = phone,
                    Endereco = endereco,
                };

                if (service.AddContact((contato)))
                    Console.WriteLine($"Contato foi adicionado com sucesso");
                else
                    Console.WriteLine("Nome ou Email invalido");

                Console.WriteLine("___________________________________________________");
                Console.WriteLine();

            }


            void GetAllContacts()
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("___________________________________________________");

                Console.WriteLine("Contatos:");
                List<Contato> _contatos = service.GetContacts();
                foreach (Contato contato in _contatos)
                {
                    Console.WriteLine($"{contato.Id}\t{contato.Name}\t{contato.Email}");
                }
                Console.WriteLine("___________________________________________________");
                Console.WriteLine();
            }

            void RemoveContact()
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("___________________________________________________");
                Console.WriteLine("Qual o id do contato que você deseja remover?");
                int id = int.Parse(Console.ReadLine());
                Contato contato = service.GetContato(id);
                service.RemoveContact(contato);
                Console.WriteLine("___________________________________________________");
                Console.WriteLine();

            }

            void EditContact()
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("___________________________________________________");
                Console.WriteLine("Qual o id do contato que você deseja editar?");
                int id = int.Parse(Console.ReadLine());
                Contato contatoToEdit = service.GetContato(id);
                Console.WriteLine("Informe o novo nome");
                string nName = Console.ReadLine();
                Console.WriteLine("Informe o novo email");
                string nEmail = Console.ReadLine();
                Console.WriteLine("Informe o novo telefone");
                string nPhone = Console.ReadLine();

                contatoToEdit.Name = nName;
                contatoToEdit.Email = nEmail;
                contatoToEdit.Phone = nPhone;

                Console.WriteLine("Deseja alterar o endereço?");
                Console.WriteLine("1 - Sim");
                Console.WriteLine("2 - Não");
                string userChoice = Console.ReadLine();



                if (userChoice == "1")
                {
                    Console.WriteLine("Digite a cidade");
                    string city = Console.ReadLine();
                    Console.WriteLine("Digite o nome da rua");
                    string streetNumber = Console.ReadLine();
                    Console.WriteLine("Digite o bairro");
                    string province = Console.ReadLine();
                    Console.WriteLine("Digite o Estado");
                    string uf = Console.ReadLine();
                    Console.WriteLine("Digite o Numero da residencia");
                    string number = Console.ReadLine();

                    Endereco endereco = new Endereco
                    {
                        Cidade = city,
                        Rua = streetNumber,
                        Bairro = province,
                        Estado = uf,
                        Numero = number
                    };
                    //                 contatoToEdit.Endereco = endereco;
                    if (service.EditContact(contatoToEdit, nName, nEmail, nPhone, true, endereco))
                        Console.WriteLine("Contato editado");
                    else
                        Console.WriteLine("Erro editando contato");

                }
                else
                {
                    if (service.EditContact(contatoToEdit, nName, nEmail, nPhone, false, null))
                        Console.WriteLine("Contato editado");
                    else
                    {
                        Console.WriteLine("Erro editando contato");
                    }
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("___________________________________________________");

            }

        }
    }
}

