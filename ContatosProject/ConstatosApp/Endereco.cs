namespace ConstatosApp;

public class Endereco
{
    public int Id { get; set; }
    public string Rua { get; set; }
    public string Bairro { get; set; }
    public int Numero { get; set; }
    public string Cidade { get; set; }
    public string Estado { get; set; }

    public Endereco() { }

    public Endereco(string rua, string bairro, int numero, string cidade, string estado)
    {
        Rua = rua;
        Bairro = bairro;
        Numero = numero;
        Cidade = cidade;
        Estado = estado;
    }
}
