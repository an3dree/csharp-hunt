public class Endereco
{
        string Rua {get; set;}
        string Bairro {get; set;}
        int Numero {get; set;}
        string Cidade {get; set;}
        string Estado {get; set;}

        public Endereco(){}

        public Endereco(string rua, string bairro, int numero, string cidade, string estado)
        {
                Rua = rua;
                Bairro = bairro;
                Numero = numero;
                Cidade = cidade;
                Estado = estado;
        }
} 
