using System;
using System.Collections.Generic;

namespace Scaffolding.Models;

public partial class TypeEvaluation
{
    public int Id { get; set; }

    public string? DesignationEvaluation { get; set; }

    public string? LibEvaluation { get; set; }

    public double? BaremEvaluation { get; set; }

    public DateTime? DateCreation { get; set; }
}
