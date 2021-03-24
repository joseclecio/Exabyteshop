using LojaVirtual.Models.Notifications;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Models
{
    public class Produto : Notifies
    {
        [Display(Name = "Código")]
        public int ProdutoID { get; set; }

        [Display(Name = "Nome")]
        [MaxLength(255)]
        public string Nome { get; set; }

        [Display(Name = "Descricao")]
        [MaxLength(150)]
        public string Descricao { get; set; }

        [Display(Name = "Observacao")]
        [MaxLength(20000)]
        public string Observacao { get; set; }

        [Display(Name = "Valor")]
        public decimal Valor { get; set; }

        [Display(Name = "QuantidadeEstoque")]
        public int QuantidadeEstoque { get; set; }

        [Display(Name = "Usuario")]
        [ForeignKey("Usuario")]
        [Column(Order = 1)]
        public string UsuarioID { get; set; }
        public virtual Usuario Usuario { get; set; }


        [Display(Name = "Estado")]
        public bool Estado { get; set; }

        [Display(Name = "DataCadastro")]
        public DateTime DataCadastro { get; set; }

        [Display(Name = "DataAlteracao")]
        public DateTime DataAlteracao { get; set; }
    }
}
