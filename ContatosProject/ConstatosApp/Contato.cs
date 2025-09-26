namespace ConstatosApp;

public class Contato
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public Endereco Endereco { get; set; }

    public Contato() { }

    public Contato(int id, string name, string email, string phone, Endereco endereco)
    {
        Name = name;
        Phone = phone;
        Email = email;
        Endereco = endereco;
    }

    public bool IsValid()
    {
        return !string.IsNullOrWhiteSpace(Name) && Email.Contains("@");
    }

}


