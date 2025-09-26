namespace ConstatosApp;

public class Service
{
    private readonly List<Contato> _contatos;

    public Service()
    {
        _contatos = new List<Contato>();
    }

    public List<Contato> GetContacts()
    {
        return _contatos;
    }

    public Contato GetContato(string name)
    {
        return _contatos.FirstOrDefault(c => c.Name == name);
    }

    public Contato GetContato(int id)
    {
        return _contatos.FirstOrDefault(c => c.Id == id);
    }

    public void LoadContacts(List<Contato> contatos)
    {
        foreach (Contato contato in contatos)
        {
            _contatos.Add(contato);
        }
    }

    public bool AddContact(Contato contato)
    {


        if (contato.IsValid())
        {
            var contactWithSameEmail = _contatos.FirstOrDefault(c => c.Email == contato.Email);

            if (contactWithSameEmail != null)
            {
                Console.WriteLine("Email alredy in use");
                return false;
            }
            else
            {
                _contatos.Add(contato);
                return true;
            }
        }
        else
        {
            return false;
        }
        //        return false;
    }

    public bool RemoveContact(Contato contato)
    {
        if (_contatos.Remove(contato))
            return true;
        else
            return false;
    }

    public bool EditContact(
        Contato contato,
        string name,
        string email,
        string phone,
        bool editEndero,
        Endereco endereco
        )
    {
        Contato contatoToEdit = _contatos.FirstOrDefault(c => c.Id == contato.Id);
        contatoToEdit.Name = name;
        contatoToEdit.Email = email;
        contatoToEdit.Phone = phone;
        if (editEndero)
            contatoToEdit.Endereco = endereco;

        if (contatoToEdit.IsValid())
            return true;
        else
            return false;

    }

}
