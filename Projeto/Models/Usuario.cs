using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Projeto.Models
{
    [Table("TB_USUARIO")]
    public class Usuario
    {
        [Key]
        public int ID_USUARIO { get; set; }
        [Required]
        public string NOME { get; set; }
        [Required]
        public string TELEFONE { get; set; }
        [Required]
        public string ESTADO { get; set; }

        public virtual ICollection<Usuario> Usuarios { get; set; }

    }
}