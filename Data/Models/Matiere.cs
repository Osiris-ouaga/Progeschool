using System;
using System.Collections.Generic;

namespace Scaffolding.Models;

public partial class Matiere
{
    public int Id { get; set; }

    public string? DesignationMatiere { get; set; }

    public string? LibMatiere { get; set; }

    public int? CoefficientMatiere { get; set; }

    public DateTime? DateCreation { get; set; }

    public int? IdNiveau { get; set; }

    public int? IdCycle { get; set; }

    public virtual ICollection<EmployeEnseignant> EmployeEnseignants { get; set; } = new List<EmployeEnseignant>();

    public virtual Cycle? IdCycleNavigation { get; set; }

    public virtual Niveau? IdNiveauNavigation { get; set; }

    public virtual ICollection<Enseignant1> IdEnseignants { get; set; } = new List<Enseignant1>();
}
