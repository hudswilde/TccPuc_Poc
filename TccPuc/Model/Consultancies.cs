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
        public int id { get; set; }

        [Display(Name = "Departamento")]
        [Column("Department")]
        public String department { get; set; }

        [Display(Name = "Setor")]
        [Column("Sector")]
        public String sector { get; set; }

        [Display(Name = "Compania")]
        [Column("Company")]
        public String company { get; set; }

        [Display(Name = "Cnpj")]
        [Column("Cnpj")]
        public String cnpj { get; set; }

        [Display(Name = "HiringDate")]
        [Column("HiringDate")]
        public DateTime hiringDate { get; set; }

        [Display(Name = "Data início")]
        [Column("StartDate")]
        public DateTime startDate { get; set; }

        [Display(Name = "Data Fim")]
        [Column("EndDate")]
        public DateTime endDate { get; set; }

        [Display(Name = "Situação")]
        [Column("Situation")]
        public String situation { get; set; }

        [Display(Name = "Ativo")]
        [Column("Active")]
        public bool active { get; set; }
    }
}
