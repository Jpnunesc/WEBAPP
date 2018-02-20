using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Projeto.Models
{
    [Table("TB_PARCEIROS")]
    public class Parceiro
    {
        [Key]
        public int ID_PARCEIRO { get; set; }
        [Required]
        public string NOME { get; set; }
        [Required]
        public string DESCRICAO { get; set; }
        [Required]
        public string IMAGEM { get; set; }
    }
}