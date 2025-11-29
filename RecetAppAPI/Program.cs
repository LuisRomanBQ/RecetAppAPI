using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Http.Json;
using Microsoft.EntityFrameworkCore;
using RecetAppAPI.Data;
using RecetAppAPI.Models;

var builder = WebApplication.CreateBuilder(args);

// JSON
builder.Services.ConfigureHttpJsonOptions(opts =>
{
    opts.SerializerOptions.PropertyNamingPolicy = null;
    opts.SerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.Never;
});

// DbContext
builder.Services.AddDbContext<RecetAppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
);

// ==== SWAGGER ====
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// ==================

var app = builder.Build();

// Activar Swagger solo en Development
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Lista en memoria
List<Usuario> users = new()
{
    new Usuario
    {
        UsuarioId = 1,
        UsuarioNombre = "Luis",
        UsuarioCorreo = "luis123@gmail.com",
        UsuarioContraseña = "1234"
    },
    new Usuario
    {
        UsuarioId = 2,
        UsuarioNombre = "Jose",
        UsuarioCorreo = "jose123@gmail.com",
        UsuarioContraseña = "1234"
    },
    new Usuario
    {
        UsuarioId = 3,
        UsuarioNombre = "Juan",
        UsuarioCorreo = "juan123@gmail.com",
        UsuarioContraseña = "1234"
    }
};

int NextId() => users.Count == 0 ? 1 : users.Max(t => t.UsuarioId) + 1;

// GET /api/users
app.MapGet("/api/users", () =>
{
    return Results.Ok(users);
});

// POST /api/users
app.MapPost("/api/users", (Usuario input) =>
{
    if (!ValidarUser(input))
        return Results.BadRequest(new { message = "Llene los campos requeridos" });

    var nuevo = new Usuario
    {
        UsuarioId = NextId(),
        UsuarioNombre = input.UsuarioNombre,
        UsuarioCorreo = input.UsuarioCorreo,
        UsuarioContraseña = input.UsuarioContraseña
    };

    users.Add(nuevo);
    return Results.Created($"/api/users/{nuevo.UsuarioId}", nuevo);
});

// PUT /api/users/{ID}
app.MapPut("/api/users/{ID:int}", (int ID, Usuario input) =>
{
    var edit = users.FirstOrDefault(t => t.UsuarioId == ID);
    if (edit == null)
        return Results.NotFound();

    if (!ValidarUser(input))
        return Results.BadRequest(new { message = "Llene los campos requeridos" });

    edit.UsuarioNombre = input.UsuarioNombre;
    edit.UsuarioCorreo = input.UsuarioCorreo;
    edit.UsuarioContraseña = input.UsuarioContraseña;

    return Results.NoContent();
});

// DELETE /api/users/{ID}
app.MapDelete("/api/users/{ID:int}", (int ID) =>
{
    var user = ObtenerUsuarioID(ID);
    if (user == null)
        return Results.NotFound();

    users.Remove(user);
    return Results.Ok();
});

app.Run();

// Helpers

bool BuscarUsuarioID(int ID)
{
    foreach (var user in users)
    {
        if (user.UsuarioId == ID)
            return true;
    }
    return false;
}

Usuario? ObtenerUsuarioID(int ID)
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
