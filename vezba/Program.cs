namespace vezba;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Sa kosova si pare uzeo
        //4 firme si otvorioo
        
        // Add services to the container.
        builder.Services.AddAuthorization();

        Console.WriteLine("MVP debeli");
        Console.WriteLine("BIG Zu MIP");
        
       Console.Write("Lazar brach");
        Console.Write("Drugi tekst dodat");
        var app = builder.Build();
        
        app.UseHttpsRedirection();

        app.UseAuthorization();
        
        app.Run();
    }
}