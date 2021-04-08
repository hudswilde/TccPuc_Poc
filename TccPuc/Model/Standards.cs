using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TccPuc.Model
{
    [Table("standards")]
    public class Standards
	{
        [Display(Name = "Organização")]
        [Column("Organization")]
        public String organization { get; set; }

        [Display(Name = "Titulo")]
        [Column("Title")]
        public String title { get; set; }

        [Display(Name = "Código")]
        [Column("Code")]
        public String code { get; set; }

        [Display(Name = "Arquivo")]
        [Column("File")]
        public String file { get; set; }

        [Display(Name = "Data Release")]
        [Column("ReleaseDate")]
        public DateTime releaseDate { get; set; }

        [Display(Name = "Data início")]
        [Column("ValidStartDate")]
        public DateTime validStartDate { get; set; }

        [Display(Name = "Data de Criação")]
        [Column("CreatedDate")]
        public DateTime createdDate { get; set; }

        [Display(Name = "Valido")]
        [Column("Valid")]
        public bool valid { get; set; }

        [Display(Name = "Descrição")]
        [Column("Description")]
        public String description { get; set; }

        [Display(Name = "Id")]
        [Column("Id")]
        public int id { get; set; }

        [Display(Name = "Versão")]
        [Column("Version")]
        public int version { get; set; }

    }
}
