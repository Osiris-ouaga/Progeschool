using System;
using System.Collections.Generic;

namespace Scaffolding.Models;

public partial class Niveau
{
    public int Id { get; set; }

    public string? DesignationNiveau { get; set; }

    public string? LibNiveau { get; set; }

    public DateTime? DateCreation { get; set; }

    public virtual ICollection<ClasseRelation> ClasseRelations { get; set; } = new List<ClasseRelation>();

    public virtual ICollection<Matiere> Matieres { get; set; } = new List<Matiere>();
}
