using ApiCrud.Data;
using Microsoft.EntityFrameworkCore;
namespace ApiCrud.Estudante;

/// <summary>
/// Classe estática para adicionar rotas relacionadas aos estudantes no aplicativo Web.
/// </summary>
public static class EstudantesRotas
{
    /// <summary>
    /// Método de extensão para adicionar rotas de estudantes ao aplicativo Web.
    /// </summary>
    /// <param name="app">O objeto WebApplication.</param>
    public static void AddRotasEstudantes(this WebApplication app)
    {
        // Adicionando um grupo de rotas
        var rotasEstudantes = app.MapGroup("/estudantes");

        // Adicionando uma rota de POST
        rotasEstudantes.MapPost(pattern: "", handler: async (AddEstudanteRequest request, AppDbContext context, CancellationToken ct) =>
        {
            // Verifica se já existe um estudante com o mesmo nome
            var jaExiste = context.Estudantes.AnyAsync(estudante => estudante.Nome == request.Nome, ct);
            if (await jaExiste)
            {
                return Results.BadRequest("Já existe um estudante com esse nome");
            }

            // Adiciona um novo estudante
            var novoEstudante = new Estudante(request.Nome);
            await context.Estudantes.AddAsync(novoEstudante, ct);
            await context.SaveChangesAsync(ct);

            var estudanteRetornado = new EstudanteDto(novoEstudante.Id, novoEstudante.Nome);
            return Results.Ok(estudanteRetornado);
        });

        // Adicionando uma rota de GET
        app.MapGet(pattern: "", handler: async (AppDbContext context, bool? ativo, CancellationToken ct) =>
        {
            var query = context.Estudantes.AsQueryable();

            // Filtrar estudantes ativos ou inativos
            if (ativo.HasValue)
            {
                query = query.Where(estudante => estudante.Ativo == ativo.Value);
            }

            var estudantes = await query.Select(estudante => new EstudanteDto(estudante.Id, estudante.Nome)).ToListAsync(ct);
            return Results.Ok(estudantes);
        });

        // Adicionando uma rota de PUT
        rotasEstudantes.MapPut(pattern: "/{id:guid}", handler: async (Guid id, AddEstudanteRequest request, AppDbContext context, CancellationToken ct) =>
        {
            var estudante = await context.Estudantes.SingleOrDefaultAsync(estudante => estudante.Id == id, ct);
            if (estudante == null)
            {
                return Results.NotFound();
            }

            // Atualiza os dados do estudante
            estudante.AlterarDadosEstudante(request.Nome);
            await context.SaveChangesAsync(ct);

            return Results.Ok(new EstudanteDto(estudante.Id, estudante.Nome));
        });

        // Adicionando uma rota de DELETE
        rotasEstudantes.MapDelete(pattern: "/{id:guid}", handler: async (Guid id, AppDbContext context, CancellationToken ct) =>
        {
            var estudante = await context.Estudantes.SingleOrDefaultAsync(estudante => estudante.Id == id, ct);
            if (estudante == null)
            {
                return Results.NotFound();
            }

            // Desativa o estudante
            estudante.DesativarEstudante();
            
            // realmente deleta o estudante
            // context.Estudantes.Remove(estudante);
            await context.SaveChangesAsync(ct);

            return Results.Ok();
        });
    }
}
