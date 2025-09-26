namespace Contatos.Tests;
using ConstatosApp;

public class ServiceTests
{
    Random random = new Random();
    Service service = new Service();
    [Fact]
    public void AddContact_WithValidContact_MustReturnTrue()
    {
        // 1  Arrange
        var contato = new Contato
        {
            Id = random.Next(200, 999),
            Name = "Tokyo Blade",
            Email = "tokyo@blade.com",
            Phone = "83 4234-4432",
            Endereco = new Endereco
            {
                Id = 1332,
                Rua = "55",
                Cidade = "Recife",
                Bairro = "Areias",
                Estado = "PE",
                Numero = "12"
            }

        };

        // 2 Act
        var result = service.AddContact(contato);

        // 3 Assert
        Assert.True(result);
    }

    [Fact]
    public void AddContact_WithInvalidContact_MustReturnTrue()
    {
        var contato = new Contato
        {
            Id = random.Next(200, 999),
            Name = " ",
            Email = "tokyo@blade.com",
            Phone = "83 4234-4432",
            Endereco = new Endereco
            {
                Id = 1332,
                Rua = "55",
                Cidade = "Recife",
                Bairro = "Areias",
                Estado = "PE",
                Numero = "12"
            }

        };

        // 2 Act
        var result = service.AddContact(contato);

        // 3 Assert
        Assert.False(result);
    }

    [Fact]
    public void AddContact_WithEmailInUse_MustReturnFalse()
    {
        // 1 - Arrange
        var contato = new Contato
        {
            Id = random.Next(200, 999),
            Name = "Teste mesmo email",
            Email = "teste1@email.com",
            Phone = "83 4234-4432",
            Endereco = new Endereco
            {
                Id = 1332,
                Rua = "55",
                Cidade = "Recife",
                Bairro = "Areias",
                Estado = "PE",
                Numero = "12"
            }

        };
        service.AddContact(contato);

        // 2 - Act
        result = service.AddContact(contato);

        // 3 - Assert
        //


    }
}
