using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TccPuc.Model
{
    [Table("consultancies")]
    public class Consultancies
	{
        [Display(Name = "Id")]
        [Column("Id")]
        public int Id { get; set; }

        [Display(Name = "Departamento")]
        [Column("Department")]
        public String Department { get; set; }

        [Display(Name = "Setor")]
        [Column("Sector")]
        public String Sector { get; set; }

        [Display(Name = "Compania")]
        [Column("Company")]
        public String Company { get; set; }

        [Display(Name = "Cnpj")]
        [Column("Cnpj")]
        public String Cnpj { get; set; }

        [Display(Name = "HiringDate")]
        [Column("HiringDate")]
        public DateTime HiringDate { get; set; }

        [Display(Name = "Data início")]
        [Column("StartDate")]
        public DateTime StartDate { get; set; }

        [Display(Name = "Data Fim")]
        [Column("EndDate")]
        public DateTime EndDate { get; set; }

        [Display(Name = "Situação")]
        [Column("Situation")]
        public String Situation { get; set; }

        [Display(Name = "Ativo")]
        [Column("Active")]
        public bool Active { get; set; }
    }
}
