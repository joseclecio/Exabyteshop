using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using LojaVirtual.Models.Enum;
using LojaVirtual.Models.Notifications;

namespace LojaVirtual.Models
{

    public class CompraUsuario : Notifies
    {
        [Display(Name = "Código")]
        public int CompraUsuarioID { get; set; }

        [Display(Name = "Produto")]
        [ForeignKey("Produto")]
        [Column(Order = 1)]
        public int ProdutoID { get; set; }
        public virtual Produto Produto { get; set; }

        [Display(Name = "EnumEstadoCompra")]
        public EnumEstadoCompra EnumEstadoCompra { get; set; }

        [Display(Name = "Quantidade")]
        public int Quantidade { get; set; }


        [ForeignKey("Usuario")]
        [Column(Order = 1)]
        public string UsuarioID { get; set; }
        public virtual Usuario Usuario { get; set; }


    }
}
