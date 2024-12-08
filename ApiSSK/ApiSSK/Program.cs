using Microsoft.EntityFrameworkCore;
using ApiSSK.Data;
using ApiSSK.Repositories;
using ApiSSK.Repositories.Interfaces;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<DataContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DataBase")));


builder.Services.AddScoped<ICalendarioRepository, CalendarioRepository>();
builder.Services.AddScoped<ICategoriaRepository, CategoriaRepository>();
builder.Services.AddScoped<ICategoriaDivisaoRepository, CategoriaDivisaoRepository>();
builder.Services.AddScoped<IDivisaoRepository, DivisaoRepository>();
builder.Services.AddScoped<IInscricaoRepository, InscricaoRepository>();
builder.Services.AddScoped<IKartodromoRepository, KartodromoRepository>();
builder.Services.AddScoped<IMelhorVoltaRepository, MelhorVoltaRepository>();
builder.Services.AddScoped<IMelhorVoltaDescRepository, MelhorVoltaDescRepository>();
builder.Services.AddScoped<IPilotoRepository, PilotoRepository>();
builder.Services.AddScoped<IPontuacaoRepository, PontuacaoRepository>();
builder.Services.AddScoped<IPontuacaoPilotoEtapaRepository, PontuacaoPilotoEtapaRepository>();
builder.Services.AddScoped<ITemporadaRepository, TemporadaRepository>();
builder.Services.AddScoped<ITracadoRepository, TracadoRepository>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();