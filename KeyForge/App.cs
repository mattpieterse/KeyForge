namespace KeyForge;

public abstract class App {
    /* Entry point for the application.
     */

    public static void Main(string[] args) {
        /* Create and configure the application.
         */

        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddRazorPages();

        var webapp = builder.Build();

        // - HTTP Pipeline

        if (!webapp.Environment.IsDevelopment()) {
            webapp.UseExceptionHandler("/Error");
            webapp.UseHsts();
        }

        // - Configuration

        webapp.UseHttpsRedirection();
        webapp.UseStaticFiles();
        webapp.UseRouting();
        webapp.UseAuthorization();
        webapp.MapRazorPages();
        webapp.Run();
    }
}