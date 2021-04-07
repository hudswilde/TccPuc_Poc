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
        public String Organization { get; set; }

        [Display(Name = "Titulo")]
        [Column("Title")]
        public String Title { get; set; }

        [Display(Name = "Código")]
        [Column("Code")]
        public String Code { get; set; }

        [Display(Name = "Arquivo")]
        [Column("File")]
        public String File { get; set; }

        [Display(Name = "Data Release")]
        [Column("ReleaseDate")]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Data início")]
        [Column("ValidStartDate")]
        public DateTime ValidStartDate { get; set; }

        [Display(Name = "Data de Criação")]
        [Column("CreatedDate")]
        public DateTime CreatedDate { get; set; }

        [Display(Name = "Valido")]
        [Column("Valid")]
        public bool Valid { get; set; }

        [Display(Name = "Descrição")]
        [Column("Description")]
        public String Description { get; set; }

        [Display(Name = "Id")]
        [Column("Id")]
        public int Id { get; set; }

        [Display(Name = "Versão")]
        [Column("Version")]
        public int Version { get; set; }

    }
}
