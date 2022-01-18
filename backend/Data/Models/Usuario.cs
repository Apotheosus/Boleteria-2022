using Microsoft.AspNetCore.Identity;

namespace BoleteriaOnline.Web.Data.Models;

public enum Gender
{
    NOTDEFINED,
    MALE,
    FEMALE,
    NOT_BINARY
}

public enum UsuarioTipo
{
    NORMAL_USER,
    SELLER,
    ADMIN
}

public class Usuario : IdentityUser<long>
{
    public string? Username { get; set; }
    public string? Password { get; set; }
    public string? Salt { get; set; }
    public DateTime BirthDate { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public Gender Gender { get; set; } = Gender.NOTDEFINED;
    public UsuarioTipo Tipo { get; set; } = UsuarioTipo.NORMAL_USER;
}
