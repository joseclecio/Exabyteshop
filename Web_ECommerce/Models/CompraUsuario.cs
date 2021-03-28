using Entities.Entities.Enums;
using Entities.Notifications;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Entities
{

    public class CompraUsuario : Notifies
    {
        [Display(Name = "Código")]
        public string CompraUsuarioID { get; set; }

        [Display(Name = "Produto")]
        [ForeignKey("Produto")]
        [Column(Order = 1)]
        public string ProdutoID { get; set; }
        public virtual Produto Produto { get; set; }

        [Display(Name = "EnumEstadoCompra")]
        public EnumEstadoCompra EnumEstadoCompra { get; set; }

        [Display(Name = "Quantidade")]
        public int Quantidade { get; set; }


        [ForeignKey("Usuario")]
        [Column(Order = 1)]
        public string Id { get; set; }
        public virtual Usuario Usuario { get; set; }


        [NotMapped]
        [Display(Name = "Quantidade Total")]
        public int QuantidadeProdutos { get; set; }

        [NotMapped]
        [Display(Name = "Valor Total")]
        public decimal ValorTotal { get; set; }

        [NotMapped]
        [Display(Name = "Endereço de entrega")]
        public string EnderecoCompleto { get; set; }

        [NotMapped]
        public List<Produto> ListaProdutos { get; set; }


    }
}
