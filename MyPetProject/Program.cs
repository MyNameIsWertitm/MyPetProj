namespace MyPetProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var app = builder.Build();

            app.UseStaticFiles();

            app.MapGet("/", () => { return Results.Redirect("/html/main.html"); });
            app.MapGet("/sd", () => { return app.Environment.EnvironmentName; });

            app.Run();
        }
    }
}
