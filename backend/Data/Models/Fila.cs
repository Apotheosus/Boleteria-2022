﻿using System.ComponentModel.DataAnnotations;

namespace BoleteriaOnline.Web.Data.Models;
public class Fila
{
    [Key]
    public int Id { get; set; }
    public List<Celda>? Cells { get; set; }

    public Planta Planta { get; set; }
}
