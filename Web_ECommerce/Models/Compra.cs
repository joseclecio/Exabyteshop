using Entities.Entities.Enums;
using Entities.Notifications;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Entities
{
    public class Compra : Notifies
    {
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Display(Name = "EnumEstadoCompra")]
        public EnumEstadoCompra Estado { get; set; }

        [Display(Name = "Data Compra")]
        public DateTime? DataCompra { get; set; }

        [Display(Name = "Usuário")]
        [ForeignKey("Usuario")]
        [Column(Order = 1)]
        public string UserId { get; set; }
        public virtual Usuario ApplicationUser { get; set; }

    }
}
