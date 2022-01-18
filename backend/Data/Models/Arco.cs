using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BoleteriaOnline.Web.Data.Models;

[Table("Arista")]
public class Arco
{
    [Key]
    public int Id { get; set; }
    public Destino Origen { get; set; }
    public Destino Destino { get; set; }
    public string Demora { get; set; }
    public double Precio { get; set; }
}
