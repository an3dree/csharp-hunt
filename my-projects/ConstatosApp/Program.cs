// See https://aka.ms/new-console-template for more information
using System.Text.Json;


List<Contato> contatos = new List<Contato>();

string dataFilePath = "./workspace/csharp-hunt/my-projects/ConstatosApp/data.json";

if (File.Exists(dataFilePath))
{
	string fileContent = File.ReadAllText(dataFilePath);
	List<Contato> loadedContacts = JsonSerializer.Deserialize<List<Contato>>(fileContent);
	foreach(Contato contato in loadedContacts)
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
			break;
		case 4:
			break;
		case 5:
			break;
	}


} while (userOption != 5);

Console.WriteLine("Obrigado por usar andrev agenda"); 

var data = JsonSerializer.Serialize(contatos);
File.WriteAllText(data, dataFilePath);


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

void AddContact()
{
  Consoe.Write;
	Console.WriteLine("Certo, vamos adicionar um novo contato!");
	Console.WriteLine("Primeiro me fala, qual o nome do contato?");
	var fName = Console.ReadLine();
	Console.WriteLine("E o sobrenome?");
	var lName = Console.ReadLine();
	var fullName = $"{fName} {lName}";
	Console.WriteLine("Qual o email do contato?");
	var email = Console.ReadLine();
	Console.WriteLine("Qual o telefone do contato?");
	var phone = Console.ReadLine();
	Console.WriteLine("Qual a cidade?");
	var city = Console.ReadLine();
	Console.WriteLine("Qual o estado?");
	var uf = Console.ReadLine();
	Console.WriteLine("Qual o bairro?");
	var province = Console.ReadLine();
	Console.WriteLine("Qual a rua?");
	var streetName = Console.ReadLine();
	Console.WriteLine("Qual o número a residência?");
	int streetNumber = int.Parse(Console.ReadLine());

	Contato contato = new Contato();
	contato.FirstName = fName;
	contato.LastName = lName;
	contato.FullName = fullName;
	contato.Email = email;
	contato.Phone = phone;
	contato.Endereco.Rua = streetName;
	contato.Endereco.Bairro = province;
	contato.Endereco.Cidade = city;
	contato.Endereco.Estado = uf;
	contato.Endereco.Numero = streetNumber;

	contatos.Add(contato);
	Console.WriteLine($"Contato {contato.FullName} foi adicionado com sucesso");

}


void GetAllContacts()
{
	Console.WriteLine("Contatos:");
	foreach(Contato contato in contatos)
	{
		Console.WriteLine($"{contato.Id}\t{contato.FullName}\t{contato.Email}");
	}
}
