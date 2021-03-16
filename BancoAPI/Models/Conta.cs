using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BancoAPI.Models
{
    public class Conta
    {
        public int ContaId { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string CodBanco { get; set; }

        [Required]
        [Column(TypeName = "varchar(16)")]
        public string NumeroConta { get; set; }

        [Required]
        [Column(TypeName = "varchar(15)")]
        public string NumeroAgencia { get; set; }

        [Required]
        [Column(TypeName = "varchar(15)")]
        public string Cpf { get; set; }

        [Required]
        [Column(TypeName = "varchar(30)")]
        public string NomeTitular { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public DateTime dataAbertura { get; set; }
    }
}
