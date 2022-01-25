using System.ComponentModel.DataAnnotations;

namespace BoleteriaOnline.Web.ViewModels.Requests;
public class DestinoRequest
{
    [Required, Display(Name = "nombre"), StringLength(100)]
    public string Nombre { get; set; }

}
