
namespace AnimalPet
{
    class Animal
    {
        private string nome;
        public string Nome
        {
            get { return this.nome; }
            set { this.nome = value; }
        }

        private string especie;
        public string Especie
        {
            get { return this.especie; }
            set
            {
                if (value == "cachorro" || value == "gato" || value == "peixe")
                {
                    this.especie = value;
                }
                else
                {
                    this.especie = "peixe";
                }
            }
        }

    }
}