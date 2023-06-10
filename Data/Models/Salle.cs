using System;
using System.Collections.Generic;

namespace Scaffolding.Models;

public partial class Salle
{
    public int Id { get; set; }

    public string? DesignationSalles { get; set; }

    public string? LibSalles { get; set; }

    public int? Capacite { get; set; }

    public int? NombrePlace { get; set; }

    public double? Superficie { get; set; }

    public DateTime? DateCreation { get; set; }
}
