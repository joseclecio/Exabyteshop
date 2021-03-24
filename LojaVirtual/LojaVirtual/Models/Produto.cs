using Models.Notifications;
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
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProdutoID { get; set; }

        [StringLength(50)]
        [Required]
        public string Nome { get; set; }

        [StringLength(200)]
        public string Descricao { get; set; }

        [StringLength(2000)]
        public string Observacao { get; set; }

        [DataType(DataType.Currency)]
        public decimal Valor { get; set; }

        public int QuantidadeEstoque { get; set; }
        public bool Estado { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAlteracao { get; set; } 

        public Usuario Usuario { get; set; }
        public int UsuarioID { get; set; }

        public ICollection<CompraUsuario> CompraUsuarios { get; set; }




    }
}
