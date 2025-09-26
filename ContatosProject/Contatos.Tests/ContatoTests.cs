namespace Contatos.Tests;
using ConstatosApp;

public class ContatoTests
{
    [Fact]
    public void IsValid_NameFilled_MustReturnTrue()
    {
        // 1. Arrange 
        var contato = new Contato
        {
            Name = "Bruce",
            Email = "bruce@tokyo.com",
            Phone = "55 8888-8888"
        };

        // 2. Act
        var result = contato.IsValid();

        // 3. Assert
        Assert.True(result);
    }

    [Fact]
    public void IsValid_NameEmpty_MustReturnFalse()
    {
        // 1. Arrange
        var contato = new Contato
        {
            Name = "",
            Email = "mark@zukerdai.com",
            Phone = "4444-321"
        };

        // 2. Prepare
        var result = contato.IsValid();

        // 3. Assert
        Assert.False(result);

    }
    [Fact]
    public void IsValid_NameWhiteSpaces_MustReturnFalse()
    {
        var contato = new Contato
        {
            Name = "  ",
            Email = "mark@out.com",
        };

        var result = contato.IsValid();

        Assert.False(result);
    }

    [Fact]
    public void IsValid_EmailWithOutAt_MustReturnFalse()
    {
        var contato = new Contato
        {
            Name = "Alot Test",
            Email = "teste.com.br",
        };

        var result = contato.IsValid();

        Assert.False(result);

    }

    [Fact]
    public void IsValid_EmailWithAt_MustReturnTrue()
    {
        var contato = new Contato
        {
            Name = "Hello Jack",
            Email = "jeck@hello"
        };

        var result = contato.IsValid();

        Assert.True(result);
    }
// TODO new tests

}
