using System;
using System.Collections.Generic;

namespace Scaffolding.Models;

public partial class Classe
{
    public int Id { get; set; }

    public string? Designation { get; set; }

    public DateTime? DateCreation { get; set; }

    public virtual ICollection<ClasseRelation> ClasseRelations { get; set; } = new List<ClasseRelation>();
}
