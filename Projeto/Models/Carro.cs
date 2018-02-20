using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Projeto.Models
{

    [Table("TB_CARRO")]
    public class Carro
    {
        [Key]
        public int ID_CARRO { get; set; }
        [Required]
        public string MARCA { get; set; }
        [Required]
        public string MODELO { get; set; }
        [Required]
        public string IMAGEM { get; set; }
        [Required]
        public string ANO { get; set; }
        public double preço { get; set; }
        public string COR { get; set; }
        public float QUILOMETRAGEM { get; set; }
        public string POTENCIA { get; set; }
        public string PAIS_ORIGEM { get; set; }
        public string BANCOS { get; set; }
        public string AR_CONDICIONADO { get; set; }
        public string VIDROS { get; set; }
        public string FREIOS { get; set; }
        public string TRACAO { get; set; }
        public string RODAS { get; set; }
        public string TIPO { get; set; }
        public string STATUS_CARRO { get; set; }
    }
}