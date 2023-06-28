var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();

app.UseHttpsRedirection();

app.MapGet("/weatherforecast", () =>
{
       return "Hello API";
})
.WithOpenApi();
app.Run();
