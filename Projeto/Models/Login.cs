using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Projeto.Models
{
    [Table("TB_LOGIN")]
    public class Login
    {
        [Key]
        public int ID_LOGIN { get; set; }
        [Required]
        public string LOGIN { get; set; }
        [Required]
        public string SENHA { get; set; }
    }
}