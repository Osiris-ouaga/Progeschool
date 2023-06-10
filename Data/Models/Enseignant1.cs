using System;
using System.Collections.Generic;

namespace Scaffolding.Models;

public partial class Enseignant1
{
    public int Id { get; set; }

    public string Qualite { get; set; } = null!;

    public string? ModeRenumeration { get; set; }

    public string? Affectation { get; set; }

    public double? Renumeration { get; set; }

    public DateTime? DateNommination { get; set; }

    public DateTime? DateSortie { get; set; }

    public virtual ICollection<EmployeEnseignant> EmployeEnseignants { get; set; } = new List<EmployeEnseignant>();

    public virtual ICollection<Matiere> IdMatieres { get; set; } = new List<Matiere>();
}
