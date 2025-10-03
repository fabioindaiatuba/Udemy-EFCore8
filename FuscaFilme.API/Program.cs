using FuscaFilme.API.DBcontexts;

var builder = WebApplication.CreateBuilder(args);

using (var context = new Context())
{
    context.Database.EnsureCreated();
}

// Add services to the container.
    // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
    builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapGet("/diretor", () =>
{
    var context = new Context();
    return context.Diretores.ToList();
})
.WithOpenApi();

app.Run();

