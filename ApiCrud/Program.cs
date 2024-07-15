using ApiCrud.Data;  // Importa o namespace que contém o contexto do banco de dados.
using ApiCrud.Estudante;  // Importa o namespace que contém as rotas dos estudantes.

var builder = WebApplication.CreateBuilder(args);

// Adiciona serviços ao contêiner.
builder.Services.AddEndpointsApiExplorer();  // Adiciona suporte para a exploração de endpoints da API.
builder.Services.AddSwaggerGen();  // Adiciona suporte para a geração de documentação Swagger.

// Registra o DbContext
builder.Services.AddDbContext<AppDbContext>();  // Adiciona o AppDbContext ao contêiner de serviços.

var app = builder.Build();  // Constrói o aplicativo web.

// Configura o pipeline de requisição HTTP.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();  // Ativa o middleware para servir a documentação Swagger.
    app.UseSwaggerUI();  // Ativa o Swagger UI para facilitar a navegação da documentação da API.
}

app.UseHttpsRedirection();  // Redireciona todas as requisições HTTP para HTTPS.

// Rotas
app.AddRotasEstudantes();  // Adiciona as rotas específicas dos estudantes ao aplicativo.

app.Run();  // Inicia o aplicativo.
