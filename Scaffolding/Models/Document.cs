using System;
using System.Collections.Generic;

namespace Scaffolding.Models;

public partial class Document
{
    public int Id { get; set; }

    public string? DesignationDocument { get; set; }

    public string? Repertoire { get; set; }

    public DateTime? DateCreation { get; set; }

    public virtual ICollection<Employe> IdEmployes { get; set; } = new List<Employe>();
}
