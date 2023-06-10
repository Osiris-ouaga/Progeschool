using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class SchoolInfo
    {
        public int Id { get; set; }

        public string? Designation { get; set; }

        public string? Adresse { get; set; }

        public string? Lib { get; set; }

        public string? Email { get; set; }

        public DateTime DateCreation { get; set; }

        public string? NomFondateur { get; set; }

        public string? PrenomFondateur { get; set; }

        public string? AdresseFondateur { get; set; }

        public byte[]? Logo { get; set; }
    }

}
