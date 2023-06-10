using Scaffolding.Models;
using System.Data.Entity.Infrastructure;

namespace Business
{
    public class Class1
    {

        public bool AddAdmission(Scaffolding.Models.Admission newAdmission)
        {
            using (var context = new GescoOuagaContext())
            {
                try
                {
                    context.Admissions.Add(newAdmission);
                    context.SaveChanges();

                    // If there are no exceptions, return true
                    return true;
                }
                catch (DbUpdateException ex)
                {
                    // Log or print the error message of the inner exception
                    Console.WriteLine(ex.InnerException?.Message);

                    // If an exception is thrown, return false
                    return false;
                }
            }
        }
        public bool AddCycle(string designationCycles, string libCycles, DateTime dateCreation)
        {
            using (var context = new GescoOuagaContext())
            {
                try
                {
                    var cycle = new Cycle
                    {
                        DesignationCycles = designationCycles,
                        LibCycles = libCycles,
                        DateCreation = dateCreation
                    };

                    context.Cycles.Add(cycle);
                    context.SaveChanges();

                    // If there are no exceptions, return true
                    return true;
                }
                catch (DbUpdateException ex)
                {
                    // Log or print the error message of the inner exception
                    Console.WriteLine(ex.InnerException?.Message);

                    // If an exception is thrown, return false
                    return false;
                }
            }
        }
        public bool AddSchoolInfo(
     int id,
     string designation, string adresse, string lib,
     string email, DateTime dateCreation, string nomFondateur,
     string prenomFondateur, string adresseFondateur, byte[] logo)
        {
            using (var context = new GescoOuagaContext())
            {
                try
                {
                    var schoolInfo = new SchoolInfo
                    {
                        Id = id,
                        Designation = designation,
                        Adresse = adresse,
                        Lib = lib,
                        Email = email,
                        DateCreation = dateCreation,
                        NomFondateur = nomFondateur,
                        PrenomFondateur = prenomFondateur,
                        AdresseFondateur = adresseFondateur,
                        Logo = logo
                    };

                    context.SchoolInfos.Add(schoolInfo);
                    context.SaveChanges();

                    // If there are no exceptions, return true
                    return true;
                }
                catch (DbUpdateException ex)
                {
                    // Log or print the error message of the inner exception
                    Console.WriteLine(ex.InnerException?.Message);

                    // If an exception is thrown, return false
                    return false;
                }
            }
        }




    }
}
