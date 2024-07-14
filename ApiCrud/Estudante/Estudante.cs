namespace ApiCrud.Estudante
{
    public class Estudante
    {
        public Guid Id { get; init; }
        public bool Ativo { get; private set; }
        public string Nome { get; private set; }

        public Estudante(string nome)
        {
            Id = Guid.NewGuid();
            Ativo = true;
            Nome = nome;
        }
    }
}
