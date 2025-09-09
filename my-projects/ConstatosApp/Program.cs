// See https://aka.ms/new-console-template for more information
ShowMenu();

Contato andre = new Contato();
andre.FirstName = "André";
Console.WriteLine(andre.FirstName);


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
