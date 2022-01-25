using System.ComponentModel.DataAnnotations;

namespace BoleteriaOnline.Web.Data.Models;
public class Horario
{
    public int Id { get; set; }
    [MaxLength(5)]
    public string Hora { get; set; }
    public Distribucion Distribucion { get; set; }
    public Fila Frecuencia { get; set; }
}
