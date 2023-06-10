using System;
using System.Collections.Generic;

namespace Scaffolding.Models;

public partial class Prime
{
    public int Id { get; set; }

    public string? DesignationPrime { get; set; }

    public int? Montant { get; set; }

    public DateTime? DateCreation { get; set; }

    public virtual ICollection<Employe> IdEmployes { get; set; } = new List<Employe>();
}
