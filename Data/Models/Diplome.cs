using System;
using System.Collections.Generic;

namespace Scaffolding.Models;

public partial class Diplome
{
    public int Id { get; set; }

    public string? DesignationDiplomes { get; set; }

    public string? LibDiplomes { get; set; }

    public DateTime? DateCreation { get; set; }

    public virtual ICollection<Employe> IdEmployes { get; set; } = new List<Employe>();
}
