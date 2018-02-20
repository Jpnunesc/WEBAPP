using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Projeto.Models
{
    [Table("TB_RIFA")]
    public class Rifa
    {
        [Key]
        public int ID_RIFA { get; set; }
        [Required]
        public string IMAGEM { get; set; }
        [Required]
        public string DESCRICAO { get; set; }
        [Required]
        public double PRECO { get; set; }
        [Required]
        public string NUMERO { get; set; }
        public string STATUS { get; set; }

        public int ID_USUARIO { get; set; }

        [ForeignKey("ID_USUARIO")]
        public Usuario Usuario { get; set; }
    }
}