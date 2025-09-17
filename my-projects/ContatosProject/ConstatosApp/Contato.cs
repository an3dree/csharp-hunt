namespace ConstatosApp;

public class Contato
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string FullName { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public Endereco Endereco { get; set; }

    public Contato() { }

    public Contato(string fName, string lName, string phone, string email, Endereco endereco)
    {
        FirstName = fName;
        LastName = lName;
        FullName = $"{fName} {lName}";
        Phone = phone;
        Email = email;
        Endereco = endereco;
    }

    public bool FirstNamIsValid()
    {
        return !string.IsNullOrEmpty(FirstName);
    }

    public bool EmailIsValid()
    {
        return Email.Contains("@");
    }
}


