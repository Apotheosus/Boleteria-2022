using System.ComponentModel.DataAnnotations;
using BoleteriaOnline.Core.Data.Enums;

namespace BoleteriaOnline.Web.ViewModels.Responses;
public class UsuarioResponse
{
    public int Dni { get; set; }

    [DataType(DataType.EmailAddress)]
    public string Email { get; set; }
    public UsuarioTipo Tipo { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
}
