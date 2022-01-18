using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BoleteriaOnline.Web.Extensions;

namespace BoleteriaOnline.Web.Data.Models;

public enum Planta
{
    BAJA,
    ALTA
}

public enum DistribucionEspacio
{
    ESPACIO_NULL = -1,
    ESPACIO_PASILLO = 1,
    ESPACIO_BUTACA = 2,
    ESPACIO_TV = 3
}

public class Distribucion
{
    int cant_PB = 25;
    int cant_PA = 25;

    public int Id { get; set; }
    public List<Fila> Filas { get; set; }

    [NotMapped]
    public List<Fila> PlantaBaja => Filas.Where(f => f.Planta == Planta.BAJA).OrderBy(f => f.Id).ToList();
    [NotMapped]
    public List<Fila> PlantaAlta => Filas.Where(f => f.Planta == Planta.ALTA).OrderBy(f => f.Id).ToList();

    [StringLength(128)]
    public string Nota { get; set; }
    public bool UnPiso { get; set; }

    public Distribucion()
    {

    }

    public Distribucion(int cantidad_PB)
    {
        cant_PB = cantidad_PB;
        if (cantidad_PB / 5 > 0)
            this.InicializarListaCeldas(Planta.BAJA, cantidad_PB / 5, 5);
    }

    public Distribucion(int cantidad_PB, int cantidad_PA)
    {
        cant_PB = cantidad_PB;
        cant_PA = cantidad_PA;
        if (cantidad_PB / 5 > 0)
            this.InicializarListaCeldas(Planta.BAJA, cantidad_PB / 5, 5);
        if (cantidad_PA / 5 > 0)
            this.InicializarListaCeldas(Planta.ALTA, cantidad_PA / 5, 5);
    }
}
