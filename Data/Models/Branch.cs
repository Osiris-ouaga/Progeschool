using System;
using System.Collections.Generic;

namespace Scaffolding.Models;

public partial class Branch
{
    public int Id { get; set; }

    public string? DesignationBranches { get; set; }

    public string? LibBranches { get; set; }

    public DateTime? DateCreation { get; set; }

    public virtual ICollection<ClasseRelation> ClasseRelations { get; set; } = new List<ClasseRelation>();
}
