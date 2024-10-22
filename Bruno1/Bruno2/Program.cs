using Bruno1.Models;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AppDbContext>();
var app = builder.Build();

app.MapGet("/", () => "Projeto API_LocalizaV2!");

app.MapPost("/api/funcionario/cadastrar", ([FromBody] Funcionario funcionario,  
    [FromServices] AppDbContext ctx) =>
{
    ctx.Funcionarios.Add(funcionario);
    ctx.SaveChanges();
    return Results.Created("", funcionario);
}); 

app.MapPost("/api/folha/cadastrar", ([FromBody] Folha folha,  
    [FromServices] AppDbContext ctx) =>
{
    ctx.Folhas.Add(folha);
    ctx.SaveChanges();
    return Results.Created("", folha);
}); 

app.MapGet("/api/folha/buscar/{cpf}/{mes}/{ano}", ([FromRoute] string cpf, [FromRoute] decimal mes,  [FromRoute] decimal ano,    
    [FromServices] AppDbContext ctx) =>
{
    Folha? folha = ctx.Folhas.Find(cpf);
    if(folha is null)
    {
        return Results.NotFound();
    }
    return Results.Ok(folha);
}); 

app.MapGet("/api/funcionario/listar", ([FromServices] AppDbContext ctx) =>
{
    if(ctx.Funcionarios.Any())
    {
        return Results.Ok(ctx.Funcionarios.ToList());
    }
    return Results.NotFound();
}); 

app.MapGet("/api/folha/listar", ([FromServices] AppDbContext ctx) =>
{
    if(ctx.Folhas.Any())
    {
        return Results.Ok(ctx.Folhas.ToList());
    }
    return Results.NotFound();
}); 
app.Run();
