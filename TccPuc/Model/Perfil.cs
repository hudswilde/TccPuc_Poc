using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TccPuc.Model
{
    [Table("perfil")]
    public class Perfil
    {
        [Display(Name = "Id")]
        [Column("Id")]
        public int Id { get; set; }


        [Display(Name = "Nome")]
        [Column("Nome")]
        public String Nome { get; set; }

    }
}
