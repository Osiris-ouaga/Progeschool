using System;
using System.Collections.Generic;

namespace Scaffolding.Models;

public partial class ClasseRelation
{
    public int IdClasse { get; set; }

    public int IdNiveau { get; set; }

    public int IdCycle { get; set; }

    public int IdBranche { get; set; }

    public virtual Branch IdBrancheNavigation { get; set; } = null!;

    public virtual Classe IdClasseNavigation { get; set; } = null!;

    public virtual Cycle IdCycleNavigation { get; set; } = null!;

    public virtual Niveau IdNiveauNavigation { get; set; } = null!;
}
