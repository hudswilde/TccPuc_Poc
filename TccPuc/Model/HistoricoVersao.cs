using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TccPuc.Model
{
    [Table("historico_versoes")]
    public class HistoricoVersao
    {

        [Display(Name = "Id")]
        [Column("Id")]
        public int Id { get; set; }

        [Display(Name = "versão")]
        [Column("Versao")]
        public int Versao { get; set; }

        [Display(Name = "Data")]
        [Column("Data")]
        public DateTime Data { get; set; }

        [Display(Name = "Código Usuario")]
        [Column("Cd_Usuario")]
        public string Cd_Usuario { get; set; }
    }
}
