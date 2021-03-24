using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Models.Notifications;
using LojaVirtual.Models.Enum;


namespace LojaVirtual.Models
{
    public class CompraUsuario : Notifies
    {
        
        public int CompraUsuarioID { get; set; }
        public EnumEstadoCompra Estado { get; set; }

        [Required]
        public int Quantidade { get; set; }
        public Produto Produto { get; set; }
        public int ProdutoID { get; set; }
        public Usuario Usuario { get; set; }
        public int UsuarioID { get; set; }

    }
}
