using Microsoft.OpenApi.Models;
using PresenceManagement.webApi.Logging;
using NLog;
using PresenceManagement.DataAccess.Models;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

object value = builder.Services.AddDbContext<PresenceDbContext>(option =>{
    option.UseSqlServer(builder.Configuration.GetConnectionString("PresenceCs"));});
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSingleton<ILog,Log>();
builder.Services.AddCors(o =>{
o.AddPolicy("presence",
p => {
p.WithOrigins("adress1", "adress2");});});
builder.Configuration.GetSection("CorsOrigin").Get<string>();
string cs = builder.Configuration.GetSection("CorsOrigin").Get<string>();
string[] CorsOrigin = cs.Split(new char[','], 
StringSplitOptions.RemoveEmptyEntries);

string Pathfichier = $"{Directory.GetCurrentDirectory()}./bin/Debug/net6.0/Nlog.config";
LogManager.LoadConfiguration(Pathfichier);
builder.Services.AddSwaggerGen(c=>{c.SwaggerDoc("v1",new OpenApiInfo(){
  Title = "Gestion de presence",
  Version = "1.0.0",
  Description = "Documentation d'une Application de gestion des presences"  
});});
builder.Services.AddControllers();
var app = builder.Build();
app.UseCors("Presence");
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c=>{
        c.RoutePrefix = string.Empty;
        c.SwaggerEndpoint("/swagger/v1/swagger.json","v1");});
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
