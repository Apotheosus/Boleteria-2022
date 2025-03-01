﻿using BoleteriaOnline.Web.Data.Models.Enums;

namespace BoleteriaOnline.Web.Data.Models;
public class Auditory
{
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public Estado Estado { get; set; } = Estado.NORMAL;
}
