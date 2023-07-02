var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddDbContext<DoctorWhoDBContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DoctorWhoConnection"))
           .EnableSensitiveDataLogging()
           .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking));


var app = builder.Build();

app.UseHttpsRedirection();

app.MapGet("/", () =>
{
       return "Hello API";
})
.WithOpenApi();
app.Run();
