namespace Contatos.Tests;
using ConstatosApp;

public class ContatoTests
{
    [Fact]
    public void NameIsValid_NameFilled_MustReturnTrue()
    {
        // 1. Arrange 
        var contato = new Contato
        {
            FirstName = "Bruce",
            Email = "bruce@tokyo.com",
            Phone = "55 8888-8888"
        };

        // 2. Act
        var result = contato.NameIsValid();

        // 3. Assert
        Assert.True(result);
    }

    [Fact]
    public void NameIsValid_NameEmpty_MustReturnFalse()
    {
        // 1. Arrange
        var contato = new Contato
        {
            FirstName = "",
            Email = "mark@zukerdai.com",
            Phone = "4444-321"
        };

        // 2. Prepare
        var result = contato.NameIsValid();

        // 3. Assert
        Assert.False(result);

    }

}
