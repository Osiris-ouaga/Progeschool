using System;
using System.Collections.Generic;

namespace Scaffolding.Models;

public partial class Employe
{
    public int Id { get; set; }

    public string Badge { get; set; } = null!;

    public string? Civilite { get; set; }

    public string? Nom { get; set; }

    public string? Prenom { get; set; }

    public string? SituationFamiliale { get; set; }

    public string? NombreEnfant { get; set; }

    public string? DateNaissance { get; set; }

    public string? LieuNaissance { get; set; }

    public string? Adresse { get; set; }

    public string? CodePostal { get; set; }

    public string? Ville { get; set; }

    public string? Departement { get; set; }

    public string? Arrondissement { get; set; }

    public string? Cni { get; set; }

    public string? Nationalite { get; set; }

    public string? Contact { get; set; }

    public string? Email { get; set; }

    public string? Photo { get; set; }

    public string? Login { get; set; }

    public string? Password { get; set; }

    public DateTime? DateCreation { get; set; }

    public virtual ICollection<EmployeEnseignant> EmployeEnseignants { get; set; } = new List<EmployeEnseignant>();

    public virtual ICollection<AgentAdministratif> IdAgentAdministratifs { get; set; } = new List<AgentAdministratif>();

    public virtual ICollection<Diplome> IdDiplomes { get; set; } = new List<Diplome>();

    public virtual ICollection<Document> IdDocuments { get; set; } = new List<Document>();

    public virtual ICollection<Prime> IdPrimes { get; set; } = new List<Prime>();

    public virtual ICollection<Retenue> IdRetenues { get; set; } = new List<Retenue>();
}
