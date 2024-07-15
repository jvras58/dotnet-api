using Microsoft.EntityFrameworkCore;

namespace ApiCrud.Data
{
    /// <summary>
    /// Representa o contexto do banco de dados da aplicação.
    /// Herda de DbContext e é utilizado para interagir com o banco de dados.
    /// </summary>
    public class AppDbContext : DbContext
    {
        /// <summary>
        /// Construtor que aceita opções de configuração para o DbContext.
        /// </summary>
        /// <param name="options">Opções para configurar o contexto do banco de dados.</param>
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        /// <summary>
        /// Conjunto de dados que representa os estudantes no banco de dados.
        /// </summary>
        public DbSet<Estudante.Estudante> Estudantes { get; set; }

        /// <summary>
        /// Configurações adicionais do contexto do banco de dados.
        /// </summary>
        /// <param name="optionsBuilder">Construtor de opções para configurar o contexto do banco de dados.</param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Configura o banco de dados para usar SQLite.
                optionsBuilder.UseSqlite("Data Source=Banco.sqlite");
                
                // Configura o log para escrever no console com nível de informação.
                optionsBuilder.LogTo(Console.WriteLine, LogLevel.Information);
                
                // Habilita o log de dados sensíveis.
                optionsBuilder.EnableSensitiveDataLogging();
            }
            base.OnConfiguring(optionsBuilder);
        }
    }
}
