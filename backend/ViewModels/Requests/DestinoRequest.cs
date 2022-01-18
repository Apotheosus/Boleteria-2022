using System.ComponentModel.DataAnnotations;

namespace BoleteriaOnline.Web.ViewModels.Requests;
public class DestinoRequest
{
    [Display(Name = "identificador")]
    public int Id { get; set; }

    [Required, Display(Name = "nombre"), StringLength(100)]
    public string? Nombre { get; set; }

}
