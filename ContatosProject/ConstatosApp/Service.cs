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

    public void LoadContacts(List<Contato> contatos)
    {
        foreach (Contato contato in contatos)
        {
            _contatos.Add(contato);
        }
    }

    public bool AddContact(int id, string name, string email, string phone, Endereco endereco)
    {
        Contato contato = new Contato()
        {
            Id = id,
            Name = name,
            Email = email,
            Phone = phone,
            Endereco = endereco,
        };

        if (contato.IsValid() && contato.EmailIsValid())
        {
            _contatos.Add(contato);
            return true;
        }
        else
        {
            return false;
        }
        //        return false;
    }


}
