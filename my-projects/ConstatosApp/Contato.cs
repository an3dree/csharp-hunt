
public class Contato
{
        public string FirstName {get; set;}
        string LastName {get; set;}
        string FullName {get; set;}
        string Phone {get; set;}
        string Email {get; set;}
        Endereco Endereco {get; set;}

        public Contato(){}

        public Contato(string fName, string lName, string phone, string email, Endereco endereco)
        {
                FirstName = fName;
                LastName = lName;
                FullName = $"{fName} {lName}";
                Phone = phone;
                Email = email;
                Endereco = endereco;
        }
}


