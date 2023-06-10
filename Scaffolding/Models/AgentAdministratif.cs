using System;
using System.Collections.Generic;

namespace Scaffolding.Models;

public partial class AgentAdministratif
{
    public int Id { get; set; }

    public string DesignationFonction { get; set; } = null!;

    public string? LibFonction { get; set; }

    public string? Qualite { get; set; }

    public string? ModeRenumeration { get; set; }

    public double? Renumeration { get; set; }

    public DateTime? DateCreation { get; set; }

    public int? IdEmploye { get; set; }

    public virtual ICollection<Employe> IdEmployes { get; set; } = new List<Employe>();
}
