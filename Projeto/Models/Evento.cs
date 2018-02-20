using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Projeto.Models
{
  
    [Table("TB_EVENTOS")]
    public class Evento
    {
        [Key]
        public int ID_EVENTOS { get; set; }
        [Required]
        public string IMAGEM { get; set; }
    }
}