using System;
using System.Collections.Generic;

namespace Scaffolding.Models;

public partial class Admission
{
    public int Id { get; set; }

    public string? Niveaux { get; set; }

    public string? Branches { get; set; }

    public double? Progression { get; set; }

    public double? Rachat { get; set; }

    public double? Redouble { get; set; }

    public double? Exclus { get; set; }

    public DateTime? DateCreation { get; set; }
}
