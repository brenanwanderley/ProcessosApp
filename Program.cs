using ProcessosApp.Contexts;
using ProcessosApp.Services;

var builder = WebApplication.CreateBuilder(args);

// Registrar o HttpClient para a API do IBGE
builder.Services.AddHttpClient<IBGEService>();

// Adicionar serviços ao contêiner
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ProcessosContext>();

var app = builder.Build();

// Configurar o pipeline de requisição HTTP
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

// Redirecionar a página inicial para "/Processo"
app.MapGet("/", () => Results.Redirect("/Processo"));

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
