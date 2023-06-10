using System;
using System.Collections.Generic;

namespace Scaffolding.Models;

public partial class Appreciation
{
    public int Id { get; set; }

    public double? NoteAppreciations { get; set; }

    public double? Barem { get; set; }

    public string? ObservationEvaluation { get; set; }

    public DateTime? DateCreation { get; set; }
}
