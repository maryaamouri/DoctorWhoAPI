using DoctorWho.API.Models;
using DoctorWho.API.Validators;
using DoctorWhoData;
using DoctorWhoData.Repos;
using DoctorWhoDomain;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddControllers()
                .AddJsonOptions(opt => opt.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddDbContext<DoctorWhoDBContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DoctorWhoConnection"))
           .EnableSensitiveDataLogging()
           .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking));

builder.Services.AddHttpContextAccessor();

builder.Services.AddScoped<IDoctorRepo, DoctorRepo>();
builder.Services.AddScoped<IAuthorRepo, AuthorRepo>();
builder.Services.AddScoped<ICompanionRepo, CompanionRepo>();
builder.Services.AddScoped<IEnemyRepo, EnemyRepo>();
builder.Services.AddScoped<IEpisodeRepo, EpisodeRepo>();

builder.Services.AddScoped<IValidator<DoctorDto>,DoctorValidator>();
builder.Services.AddScoped<IValidator<AuthorDto>, AuthorValidator>();
builder.Services.AddScoped<IValidator<CompanionDto>, CompanionValidator>();
builder.Services.AddScoped<IValidator<EnemyDto>, EnemyValidator>();
builder.Services.AddScoped<IValidator<EpisodeDto>, EpisodeValidator>();

var app = builder.Build();
app.MapControllers();


app.UseHttpsRedirection();
app.UseRouting();

app.Run();
