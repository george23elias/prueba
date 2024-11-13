using Entity.Animal;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddControllersWithViews(); 

builder.Services.AddSingleton<AnimalRepository>();

var app = builder.Build();

app.MapControllers();

app.MapGet("/", () => "Hello World!");

app.Run();
