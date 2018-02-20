using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Projeto.Models
{
    [Table("TB_INSTITUICAO")]
    public class Instituicao
    {
        [Key]
        public int ID_INSTITUICAO { get; set; }
        public string NOME { get; set; }
        public string DESCRICAO { get; set; }
        public string IMAGEM { get; set; }
    }
}