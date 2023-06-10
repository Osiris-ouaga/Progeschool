using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Scaffolding.Models;

public partial class GescoOuagaContext : DbContext
{
    public GescoOuagaContext()
    {
    }

    public GescoOuagaContext(DbContextOptions<GescoOuagaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Admission> Admissions { get; set; }

    public virtual DbSet<SchoolInfo> SchoolInfos { get; set; }

    public virtual DbSet<AgentAdministratif> AgentAdministratifs { get; set; }

    public virtual DbSet<Appreciation> Appreciations { get; set; }

    public virtual DbSet<Branch> Branches { get; set; }

    public virtual DbSet<Classe> Classes { get; set; }

    public virtual DbSet<ClasseRelation> ClasseRelations { get; set; }

    public virtual DbSet<Cycle> Cycles { get; set; }

    public virtual DbSet<Diplome> Diplomes { get; set; }

    public virtual DbSet<Document> Documents { get; set; }

    public virtual DbSet<Employe> Employes { get; set; }

    public virtual DbSet<EmployeEnseignant> EmployeEnseignants { get; set; }

    public virtual DbSet<Enseignant1> Enseignants1 { get; set; }

    public virtual DbSet<Matiere> Matieres { get; set; }

    public virtual DbSet<Niveau> Niveaus { get; set; }

    public virtual DbSet<Prime> Primes { get; set; }

    public virtual DbSet<Retenue> Retenues { get; set; }

    public virtual DbSet<Salle> Salles { get; set; }

    public virtual DbSet<TypeEvaluation> TypeEvaluations { get; set; }

//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("Server=DESKTOP-LBN9HF5\\SQLEXPRESS;Database=gescoOuaga;Trusted_Connection=True;Encrypt=No");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Admission>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Pk_admissions");

            entity.ToTable("admissions");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Branches)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("branches");
            entity.Property(e => e.DateCreation)
                .HasColumnType("date")
                .HasColumnName("dateCreation");
            entity.Property(e => e.Exclus).HasColumnName("exclus");
            entity.Property(e => e.Niveaux)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("niveaux");
            entity.Property(e => e.Progression).HasColumnName("progression");
            entity.Property(e => e.Rachat).HasColumnName("rachat");
            entity.Property(e => e.Redouble).HasColumnName("redouble");
        });

        modelBuilder.Entity<SchoolInfo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Pk_SchoolInfo");

            entity.ToTable("SchoolInfo");

            entity.Property(e => e.Id).HasColumnName("id");

            entity.Property(e => e.Designation)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("designation");

            entity.Property(e => e.Adresse)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("adresse");

            entity.Property(e => e.Lib)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("lib");

            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("email");

            entity.Property(e => e.DateCreation)
                .HasColumnType("date")
                .HasColumnName("dateCreation");

            entity.Property(e => e.NomFondateur)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("nomFondateur");

            entity.Property(e => e.PrenomFondateur)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("prenomFondateur");

            entity.Property(e => e.AdresseFondateur)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("adresseFondateur");

            entity.Property(e => e.Logo).HasColumnName("logo");
        });


        modelBuilder.Entity<AgentAdministratif>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Pk_fonctions");

            entity.ToTable("agentAdministratifs");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DateCreation)
                .HasColumnType("date")
                .HasColumnName("dateCreation");
            entity.Property(e => e.DesignationFonction)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("designationFonction");
            entity.Property(e => e.IdEmploye).HasColumnName("id_employe");
            entity.Property(e => e.LibFonction)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("libFonction");
            entity.Property(e => e.ModeRenumeration)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("modeRenumeration");
            entity.Property(e => e.Qualite)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("qualite");
            entity.Property(e => e.Renumeration).HasColumnName("renumeration");
        });

        modelBuilder.Entity<Appreciation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Pk_appreciations");

            entity.ToTable("appreciations");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Barem).HasColumnName("barem");
            entity.Property(e => e.DateCreation)
                .HasColumnType("date")
                .HasColumnName("dateCreation");
            entity.Property(e => e.NoteAppreciations).HasColumnName("noteAppreciations");
            entity.Property(e => e.ObservationEvaluation)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("observationEvaluation");
        });

        modelBuilder.Entity<Branch>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Pk_branches");

            entity.ToTable("branches");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DateCreation)
                .HasColumnType("date")
                .HasColumnName("dateCreation");
            entity.Property(e => e.DesignationBranches)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("designationBranches");
            entity.Property(e => e.LibBranches)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("libBranches");
        });

        modelBuilder.Entity<Classe>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__classe__3213E83F12B56EA3");

            entity.ToTable("classe");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DateCreation)
                .HasColumnType("date")
                .HasColumnName("dateCreation");
            entity.Property(e => e.Designation)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("designation");
        });

        modelBuilder.Entity<ClasseRelation>(entity =>
        {
            entity.HasKey(e => new { e.IdClasse, e.IdNiveau, e.IdCycle, e.IdBranche }).HasName("PK__classeRe__FC6F0E2F31C0B9AE");

            entity.ToTable("classeRelation");

            entity.Property(e => e.IdClasse).HasColumnName("id_classe");
            entity.Property(e => e.IdNiveau).HasColumnName("id_niveau");
            entity.Property(e => e.IdCycle).HasColumnName("id_cycle");
            entity.Property(e => e.IdBranche).HasColumnName("id_branche");

            entity.HasOne(d => d.IdBrancheNavigation).WithMany(p => p.ClasseRelations)
                .HasForeignKey(d => d.IdBranche)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__classeRel__id_br__76969D2E");

            entity.HasOne(d => d.IdClasseNavigation).WithMany(p => p.ClasseRelations)
                .HasForeignKey(d => d.IdClasse)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__classeRel__id_cl__73BA3083");

            entity.HasOne(d => d.IdCycleNavigation).WithMany(p => p.ClasseRelations)
                .HasForeignKey(d => d.IdCycle)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__classeRel__id_cy__75A278F5");

            entity.HasOne(d => d.IdNiveauNavigation).WithMany(p => p.ClasseRelations)
                .HasForeignKey(d => d.IdNiveau)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__classeRel__id_ni__74AE54BC");
        });

        modelBuilder.Entity<Cycle>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Pk_cycles");

            entity.ToTable("cycles");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DateCreation)
                .HasColumnType("date")
                .HasColumnName("dateCreation");
            entity.Property(e => e.DesignationCycles)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("designationCycles");
            entity.Property(e => e.LibCycles)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("libCycles");
        });

        modelBuilder.Entity<Diplome>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Pk_diplomes");

            entity.ToTable("diplomes");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DateCreation)
                .HasColumnType("date")
                .HasColumnName("dateCreation");
            entity.Property(e => e.DesignationDiplomes)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("designationDiplomes");
            entity.Property(e => e.LibDiplomes)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("libDiplomes");
        });

        modelBuilder.Entity<Document>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Pk_documents");

            entity.ToTable("documents");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DateCreation)
                .HasColumnType("date")
                .HasColumnName("dateCreation");
            entity.Property(e => e.DesignationDocument)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("designationDocument");
            entity.Property(e => e.Repertoire)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("repertoire");
        });

        modelBuilder.Entity<Employe>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Pk_employe");

            entity.ToTable("employe");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Adresse)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("adresse");
            entity.Property(e => e.Arrondissement)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("arrondissement");
            entity.Property(e => e.Badge)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("badge");
            entity.Property(e => e.Civilite)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("civilite");
            entity.Property(e => e.Cni)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("cni");
            entity.Property(e => e.CodePostal)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("codePostal");
            entity.Property(e => e.Contact)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("contact");
            entity.Property(e => e.DateCreation)
                .HasColumnType("date")
                .HasColumnName("dateCreation");
            entity.Property(e => e.DateNaissance)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("dateNaissance");
            entity.Property(e => e.Departement)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("departement");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.LieuNaissance)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("lieuNaissance");
            entity.Property(e => e.Login)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("login");
            entity.Property(e => e.Nationalite)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("nationalite");
            entity.Property(e => e.Nom)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("nom");
            entity.Property(e => e.NombreEnfant)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("nombreEnfant");
            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.Photo)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("photo");
            entity.Property(e => e.Prenom)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("prenom");
            entity.Property(e => e.SituationFamiliale)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("situationFamiliale");
            entity.Property(e => e.Ville)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("ville");

            entity.HasMany(d => d.IdAgentAdministratifs).WithMany(p => p.IdEmployes)
                .UsingEntity<Dictionary<string, object>>(
                    "EmployeAgentAdministratif",
                    r => r.HasOne<AgentAdministratif>().WithMany()
                        .HasForeignKey("IdAgentAdministratif")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_EmployeAgentAdministratif_AgentAdministratif"),
                    l => l.HasOne<Employe>().WithMany()
                        .HasForeignKey("IdEmploye")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_EmployeAgentAdministratif_Employe"),
                    j =>
                    {
                        j.HasKey("IdEmploye", "IdAgentAdministratif");
                        j.ToTable("EmployeAgentAdministratif");
                        j.IndexerProperty<int>("IdEmploye").HasColumnName("id_employe");
                        j.IndexerProperty<int>("IdAgentAdministratif").HasColumnName("id_agent_administratif");
                    });

            entity.HasMany(d => d.IdDiplomes).WithMany(p => p.IdEmployes)
                .UsingEntity<Dictionary<string, object>>(
                    "EmployeDiplome",
                    r => r.HasOne<Diplome>().WithMany()
                        .HasForeignKey("IdDiplome")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_EmployeDiplome_Diplomes"),
                    l => l.HasOne<Employe>().WithMany()
                        .HasForeignKey("IdEmploye")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_EmployeDiplome_Employe"),
                    j =>
                    {
                        j.HasKey("IdEmploye", "IdDiplome").HasName("PK_EmployeDiplome");
                        j.ToTable("employeDiplome");
                        j.IndexerProperty<int>("IdEmploye").HasColumnName("id_employe");
                        j.IndexerProperty<int>("IdDiplome").HasColumnName("id_diplome");
                    });

            entity.HasMany(d => d.IdDocuments).WithMany(p => p.IdEmployes)
                .UsingEntity<Dictionary<string, object>>(
                    "EmployeDocument",
                    r => r.HasOne<Document>().WithMany()
                        .HasForeignKey("IdDocument")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_EmployeDocument_Documents"),
                    l => l.HasOne<Employe>().WithMany()
                        .HasForeignKey("IdEmploye")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_EmployeDocument_Employe"),
                    j =>
                    {
                        j.HasKey("IdEmploye", "IdDocument");
                        j.ToTable("EmployeDocument");
                        j.IndexerProperty<int>("IdEmploye").HasColumnName("id_employe");
                        j.IndexerProperty<int>("IdDocument").HasColumnName("id_document");
                    });

            entity.HasMany(d => d.IdPrimes).WithMany(p => p.IdEmployes)
                .UsingEntity<Dictionary<string, object>>(
                    "EmployePrime",
                    r => r.HasOne<Prime>().WithMany()
                        .HasForeignKey("IdPrime")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_EmployePrimes_Primes"),
                    l => l.HasOne<Employe>().WithMany()
                        .HasForeignKey("IdEmploye")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_EmployePrimes_Employe"),
                    j =>
                    {
                        j.HasKey("IdEmploye", "IdPrime").HasName("PK_EmployePrimes");
                        j.ToTable("employePrimes");
                        j.IndexerProperty<int>("IdEmploye").HasColumnName("id_employe");
                        j.IndexerProperty<int>("IdPrime").HasColumnName("id_prime");
                    });

            entity.HasMany(d => d.IdRetenues).WithMany(p => p.IdEmployes)
                .UsingEntity<Dictionary<string, object>>(
                    "EmployeRetenue",
                    r => r.HasOne<Retenue>().WithMany()
                        .HasForeignKey("IdRetenue")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_EmployeRetenues_Retenues"),
                    l => l.HasOne<Employe>().WithMany()
                        .HasForeignKey("IdEmploye")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_EmployeRetenues_Employe"),
                    j =>
                    {
                        j.HasKey("IdEmploye", "IdRetenue").HasName("PK_EmployeRetenues");
                        j.ToTable("employeRetenues");
                        j.IndexerProperty<int>("IdEmploye").HasColumnName("id_employe");
                        j.IndexerProperty<int>("IdRetenue").HasColumnName("id_retenue");
                    });
        });

        modelBuilder.Entity<EmployeEnseignant>(entity =>
        {
            entity.HasKey(e => new { e.IdEmploye, e.IdEnseignant, e.IdMatiere }).HasName("Pk_employe_enseignant");

            entity.ToTable("employe_enseignant");

            entity.Property(e => e.IdEmploye).HasColumnName("id_employe");
            entity.Property(e => e.IdEnseignant).HasColumnName("id_enseignant");
            entity.Property(e => e.IdMatiere).HasColumnName("id_matiere");

            entity.HasOne(d => d.IdEmployeNavigation).WithMany(p => p.EmployeEnseignants)
                .HasForeignKey(d => d.IdEmploye)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Fk_employe_enseignant_employe");

            entity.HasOne(d => d.IdEnseignantNavigation).WithMany(p => p.EmployeEnseignants)
                .HasForeignKey(d => d.IdEnseignant)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Fk_employe_enseignant_enseignant");

            entity.HasOne(d => d.IdMatiereNavigation).WithMany(p => p.EmployeEnseignants)
                .HasForeignKey(d => d.IdMatiere)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Fk_employe_enseignant_matiere");
        });

        modelBuilder.Entity<Enseignant1>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Pk_enseignants");

            entity.ToTable("enseignants");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Affectation)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("affectation");
            entity.Property(e => e.DateNommination)
                .HasColumnType("date")
                .HasColumnName("dateNommination");
            entity.Property(e => e.DateSortie)
                .HasColumnType("date")
                .HasColumnName("dateSortie");
            entity.Property(e => e.ModeRenumeration)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("modeRenumeration");
            entity.Property(e => e.Qualite)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("qualite");
            entity.Property(e => e.Renumeration).HasColumnName("renumeration");

            entity.HasMany(d => d.IdMatieres).WithMany(p => p.IdEnseignants)
                .UsingEntity<Dictionary<string, object>>(
                    "Enseignant",
                    r => r.HasOne<Matiere>().WithMany()
                        .HasForeignKey("IdMatiere")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_Enseignant_Matiere"),
                    l => l.HasOne<Enseignant1>().WithMany()
                        .HasForeignKey("IdEnseignant")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_Enseignant_Enseignants"),
                    j =>
                    {
                        j.HasKey("IdEnseignant", "IdMatiere").HasName("PK_Enseignant");
                        j.ToTable("enseignant");
                        j.IndexerProperty<int>("IdEnseignant").HasColumnName("id_enseignant");
                        j.IndexerProperty<int>("IdMatiere").HasColumnName("id_matiere");
                    });
        });

        modelBuilder.Entity<Matiere>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Pk_matiere");

            entity.ToTable("matiere");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CoefficientMatiere).HasColumnName("coefficientMatiere");
            entity.Property(e => e.DateCreation)
                .HasColumnType("date")
                .HasColumnName("dateCreation");
            entity.Property(e => e.DesignationMatiere)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("designationMatiere");
            entity.Property(e => e.IdCycle).HasColumnName("id_cycle");
            entity.Property(e => e.IdNiveau).HasColumnName("id_niveau");
            entity.Property(e => e.LibMatiere)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("libMatiere");

            entity.HasOne(d => d.IdCycleNavigation).WithMany(p => p.Matieres)
                .HasForeignKey(d => d.IdCycle)
                .HasConstraintName("Fk_matiere_cycle");

            entity.HasOne(d => d.IdNiveauNavigation).WithMany(p => p.Matieres)
                .HasForeignKey(d => d.IdNiveau)
                .HasConstraintName("Fk_matiere_niveau");
        });

        modelBuilder.Entity<Niveau>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Pk_niveau");

            entity.ToTable("niveau");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DateCreation)
                .HasColumnType("date")
                .HasColumnName("dateCreation");
            entity.Property(e => e.DesignationNiveau)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("designationNiveau");
            entity.Property(e => e.LibNiveau)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("libNiveau");
        });

        modelBuilder.Entity<Prime>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Pk_primes");

            entity.ToTable("primes");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DateCreation)
                .HasColumnType("date")
                .HasColumnName("dateCreation");
            entity.Property(e => e.DesignationPrime)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("designationPrime");
            entity.Property(e => e.Montant).HasColumnName("montant");
        });

        modelBuilder.Entity<Retenue>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Pk_retenues");

            entity.ToTable("retenues");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DateCreation)
                .HasColumnType("date")
                .HasColumnName("dateCreation");
            entity.Property(e => e.DesignationRetenue)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("designationRetenue");
            entity.Property(e => e.Montant).HasColumnName("montant");
        });

        modelBuilder.Entity<Salle>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Pk_salles");

            entity.ToTable("salles");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Capacite).HasColumnName("capacite");
            entity.Property(e => e.DateCreation)
                .HasColumnType("date")
                .HasColumnName("dateCreation");
            entity.Property(e => e.DesignationSalles)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("designationSalles");
            entity.Property(e => e.LibSalles)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("libSalles");
            entity.Property(e => e.NombrePlace).HasColumnName("nombrePlace");
            entity.Property(e => e.Superficie).HasColumnName("superficie");
        });

        modelBuilder.Entity<TypeEvaluation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Pk_typeEvaluation");

            entity.ToTable("typeEvaluation");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BaremEvaluation).HasColumnName("baremEvaluation");
            entity.Property(e => e.DateCreation)
                .HasColumnType("date")
                .HasColumnName("dateCreation");
            entity.Property(e => e.DesignationEvaluation)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("designationEvaluation");
            entity.Property(e => e.LibEvaluation)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("libEvaluation");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
