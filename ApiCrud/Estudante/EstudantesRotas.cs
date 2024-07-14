namespace ApiCrud.Estudante
{
    public static class EstudantesRotas
    {
        public static void AddRotasEstudantes(this WebApplication app)
        {
            app.MapGet("/estudantes", handler: () => new Estudante(nome:"tony"));
        }
    }
}