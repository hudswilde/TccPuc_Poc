using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TccPuc.Model
{
    [Table("usuario")]
    public class Usuario
    {
        [Display(Name = "Nome")]
        [Column("Nome")]
        public String Nome { get; set; }

        [Display(Name = "Senha")]
        [Column("Senha")]
        public String Senha { get; set; }

        [Key]
        [Display(Name = "Id")]
        [Column("Id")]
        public int Id { get; set; }

        [Display(Name = "Email")]
        [Column("Email")]
        public String Email { get; set; }

        [Display(Name = "Data Criação")]
        [Column("DataCriacao")]
        public DateTime DataCriacao { get; set; }

        [Display(Name = "Token")]
        [NotMapped]
        public String Token { get; set; }

        [Display(Name = "perfil")]
        [ForeignKey("Perfil")]
        [Column(Order = 1)]
        public int idPerfil { get; set; }

        public virtual Perfil Perfil { get; set; }
    }
}
