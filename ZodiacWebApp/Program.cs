namespace ZodiacWebApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();
            var app = builder.Build();

            app.UseRouting();

            app.UseStaticFiles(); //wwwroot aktif olabilmesi için middleWare'da bu kodu dahil etmemiz gerekmektedir.

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
            });

            app.Run();
        }
    }
}
