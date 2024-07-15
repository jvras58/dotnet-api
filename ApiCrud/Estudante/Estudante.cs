namespace ApiCrud.Estudante;

    /// <summary>
    /// Representa um aluno.
    /// </summary>
    public class Estudante
    {
        /// <summary>
        /// Obtém o identificador exclusivo do aluno.
        /// </summary>
        public Guid Id { get; init; }

        /// <summary>
        /// Obtém ou define um valor que indica se o aluno está ativo.
        /// </summary>
        public bool Ativo { get; private set; }

        /// <summary>
        /// Obtém ou define o nome do aluno.
        /// </summary>
        public string Nome { get; private set; }

        /// <summary>
        /// Inicializa uma nova instância do <see cref="Estudante"/> classe com o nome especificado.
        /// </summary>
        /// <param name="nome">O nome do aluno.</param>
        public Estudante(string nome)
        {
            Id = Guid.NewGuid();
            Ativo = true;
            Nome = nome;
        }

        /// <summary>
        /// Modifica o nome do aluno.
        /// </summary>
        /// <param name="nome">O novo nome do aluno.</param>
        public void AlterarDadosEstudante(string nome)
        {
            Nome = nome;
        }

        /// <summary>
        /// Define a propriedade 'Ativo' do aluno como falsa, indicando que o aluno está desativado.
        /// </summary>
        public void DesativarEstudante()
        {
            Ativo = false;
        }
    }
