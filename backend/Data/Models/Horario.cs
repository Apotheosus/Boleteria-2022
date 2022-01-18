namespace BoleteriaOnline.Web.Data.Models;
public class Horario
{
    public int Id { get; set; }
    public string? Hora { get; set; }
    public Distribucion? Distribucion { get; set; }
    public Fila? Frecuencia { get; set; }
}
