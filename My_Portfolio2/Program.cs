namespace My_Portfolio2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            var app = builder.Build();

            app.UseRouting();
            app.UseStaticFiles();
            app.UseEndpoints(
                (endPoints) => {
                    endPoints.MapControllerRoute(
                        name: "Default",
                        pattern: "{Controller=Home}/{Action=Index}"
                    );
                }
            );

            app.Run();
        }
    }
}
