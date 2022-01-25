using System.ComponentModel.DataAnnotations;

namespace BoleteriaOnline.Web.ViewModels.Requests;
public class ViajeRequest
{
    [Display(Name = "identificador")]
    public int Id { get; set; }

    [Required, Display(Name = "nombre")]
    public string Nombre { get; set; }

    //[Required, Display(Name = "horarios")]
    //public List<HorarioRequest>? Horarios { get; set; }

    [Required, Display(Name = "conexiones")]
    public List<NodoRequest> Nodos { get; set; }
}
