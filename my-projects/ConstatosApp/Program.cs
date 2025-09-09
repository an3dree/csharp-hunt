// See https://aka.ms/new-console-template for more information

List<Contato> contatos = new List<Contato>();

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
			break;
		case 3:
			break;
		case 4:
			break;
		case 5:
			break;
	}
} while (userOption != 5);

//andre.FirstName = "André";
//Console.WriteLine(andre.FirstName);
 


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

}
