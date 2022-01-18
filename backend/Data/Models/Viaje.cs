namespace BoleteriaOnline.Web.Data.Models;
public class Viaje
{
    public int Id { get; set; }
    public string? Nombre { get; set; }
    public List<Horario>? Horarios { get; set; }
    public List<Arco>? Arcos { get; set; }
}
