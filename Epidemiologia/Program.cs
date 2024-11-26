
using Capa_Logica;
using Capa_Entidad;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using Capa_Logica.CASOS_DE_USO;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


builder.Services.AddDbContext<RepEpidemiologiaContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("cn")));

builder.Services.AddScoped<RepEpidemiologiaContext>();
builder.Services.AddScoped<ServicioBL>();
builder.Services.AddScoped<PacienteBL>();
builder.Services.AddScoped<RegistroPaciente>();

//// Registrar automáticamente todas las clases dentro de un espacio de nombres específico (ej., Capa_Logica)
//builder.Services.Scan(scan => scan
//    .FromAssemblies(Assembly.GetExecutingAssembly()) // Escanea el ensamblado actual
//    .AddClasses(classes => classes.InNamespaces("C:\\Users\\HDHVCA\\Documents\\git\\Epidemiologia\\Capa Logica\\Capa Logica.csproj")) // Filtra por espacio de nombres
//    .AsSelf() // Registrar las clases por sí mismas
//    .WithScopedLifetime()); // Registrar con ciclo de vida Scoped

//builder.Services.AddControllers(); // Agregar controladores

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
