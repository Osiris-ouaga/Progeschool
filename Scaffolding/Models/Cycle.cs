using System;
using System.Collections.Generic;

namespace Scaffolding.Models;

public partial class Cycle
{
    public int Id { get; set; }

    public string? DesignationCycles { get; set; }

    public string? LibCycles { get; set; }

    public DateTime? DateCreation { get; set; }

    public virtual ICollection<ClasseRelation> ClasseRelations { get; set; } = new List<ClasseRelation>();

    public virtual ICollection<Matiere> Matieres { get; set; } = new List<Matiere>();
}
