using BoleteriaOnline.Web.Attributes;
using Humanizer;

namespace BoleteriaOnline.Web.Data.Models;
[HumanDescription("cliente", GrammaticalGender.Masculine)]
public class Cliente : Auditory
{
    public long Id { get; set; }
    public string? Nombre { get; set; }
    public DateTime FechaNac { get; set; }
    public string? Nacionalidad { get; set; }
    public Gender? Genero { get; set; }
}
