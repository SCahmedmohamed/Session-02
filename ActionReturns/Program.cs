using Microsoft.AspNetCore.Mvc;

namespace ActionReturns
{
    //[StatuesCode]
    /// 100-199 Infromational
    /// 200-299 Successful
    /// 300-399 Redirection
    /// 400-499 Client Error
    /// 500-599 Server Error

    //[ContentType]
    /// Text/html : Taking The Fromat Of Text In Html
    /// object/pdf : Download SomeThing
     
     
     

    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            var app = builder.Build();

            app.UseStaticFiles();

            app.MapControllerRoute
                (
                name: default,
                pattern: "{controller}/{action}/{id}"
                );


            app.Run();
        }
    }
}
