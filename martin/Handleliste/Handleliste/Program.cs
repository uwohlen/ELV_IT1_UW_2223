//Konfigurer webserveren
//Webserveren er ogs� ansvarlig for � h�ndtere alt rundt nettsiden

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

WebApplication app = builder.Build();


if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}


app.UseStatusCodePagesWithRedirects("/Error");

app.UseStaticFiles();

//Ruting kobler foresp�rsler fra brukeren til rettkontroller og metode
//Det kan brukes til � blant annet endre sti n�r nettsiden lastes
app.UseRouting();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
