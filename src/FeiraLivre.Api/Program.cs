using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(s =>
{
    
    s.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo 
    {
        Version = "v1",
        Title = "Feira Api Document",
        Description = "That's the api documentation of feira api.",
        Contact = new Microsoft.OpenApi.Models.OpenApiContact {
            Name = "Samir Goes",
            Email = "samir.goes@gmail.com",
            Url = new Uri("https://github.com/SamirGoes")
        }
    });

    // Set the comments path for the Swagger JSON and UI.
    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    s.IncludeXmlComments(xmlPath);
    
});

var app = builder.Build();


app.UseSwagger();
app.UseSwaggerUI(s => 
{
    s.RoutePrefix = "swagger";
    s.SwaggerEndpoint("/swagger/v1/swagger.json", "Api Feira");
});

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
