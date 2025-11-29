using RecetAppAPI.Models;
using System.Text.Json.Serialization;
using RecetAppAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sql;

var builder = WebApplication.CreateBuilder(args);

builder.Services.ConfigureHttpJsonOptions(opts =>
{
    opts.SerializerOptions.PropertyNamingPolicy = null;
    opts.SerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.Never;
});

builder.Services.AddDbContext<RecetAppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


var app = builder.Build();

//Intercepta las peticiones antes de llegar a los endpoints
app.UseHttpsRedirection();

//
List<Usuario> users = new List<Usuario>
{
    new Usuario ("Luis","luis123@gmail.com","1234"),
    new Usuario ("Jose","jose123@gmail.com","1234"),
    new Usuario ("Juan","juan123@gmail.com","1234")
};
int NextId() => (users.Count == 0) ? 1 : users.Max(t => t.UsuarioId) + 1;

//EndPoints

app.MapGet("/api/users", () =>
{
    return Results.Ok(users);
});

app.MapPost("/api/users",(Usuario input) =>
{
    if (!ValidarUser(input))
        return Results.BadRequest(new {message = "Llene los campos requeridos"});
    else
    {
        Usuario nuevo = new Usuario(NextId(),input.UsuarioNombre,input.UsuarioCorreo,input.UsuarioContraseña);
        users.Add(nuevo);
        return Results.Created($"/api/todos/{nuevo.UsuarioId}", users);
    }
});

app.MapPut("/api/users/{ID:int}", (int ID,Usuario input) =>
{
    if (BuscarUsuarioID(ID))
    {
        var edit = users.FirstOrDefault(t=>t.UsuarioId == ID);
        if(edit != null)
        {
            if (ValidarUser(input))
            {
                edit.UsuarioNombre = input.UsuarioNombre;
                edit.UsuarioCorreo = input.UsuarioCorreo;
                edit.UsuarioContraseña = input.UsuarioContraseña;
                return Results.NoContent();
            }
            return Results.BadRequest(new { message = "Llene los campos requeridos" });
        }
    }
    return Results.NotFound();
});

app.MapDelete("/api/users{id:int}", (int ID) =>
{
    if (BuscarUsuarioID(ID))
    {
        users.Remove(ObtenerUsuarioID(ID));
        return Results.Ok();
    }
    else
        return Results.NotFound();
});

app.Run();

bool BuscarUsuarioID(int ID)
{
    foreach(var user in users)
    {
        if (user.UsuarioId == ID)
            return true;
    }
    return false;
}

Usuario ObtenerUsuarioID(int ID)
{
    foreach (var user in users)
    {
        if (user.UsuarioId == ID)
            return user;
    }
    return null;
}

bool ValidarUser(Usuario input)
{
    bool valido = true;
    if (string.IsNullOrWhiteSpace(input.UsuarioNombre))
        valido = false;
    else if (string.IsNullOrWhiteSpace(input.UsuarioCorreo))
        valido = false;
    else if (string.IsNullOrWhiteSpace(input.UsuarioContraseña))
        valido = false;

    return valido;
}

