using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Projeto.Models
{

    [Table("TB_GANHADORES")]
    public class Ganhador
    {
        [Key]
        public int ID_GANHADORES { get; set; }
        [Required]
        public string NUMERO { get; set; }
        [Required]
        public string NOME { get; set; }
        [Required]
        public string TELEFONE { get; set; }



    }
}