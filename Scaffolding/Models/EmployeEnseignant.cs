using System;
using System.Collections.Generic;

namespace Scaffolding.Models;

public partial class EmployeEnseignant
{
    public int IdEmploye { get; set; }

    public int IdEnseignant { get; set; }

    public int IdMatiere { get; set; }

    public virtual Employe IdEmployeNavigation { get; set; } = null!;

    public virtual Enseignant1 IdEnseignantNavigation { get; set; } = null!;

    public virtual Matiere IdMatiereNavigation { get; set; } = null!;
}
