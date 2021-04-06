using Entities.Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Entities
{
    public class LogSistema : Base
    {
        [Display(Name = "Json Informação")]
        public string JsonInformacao { get; set; }

        [Display(Name = "Tipo Log")]
        public EnumTipoLog TipoLog { get; set; }

        [Display(Name = "Nome Controller")]
        public string NomeController { get; set; }

        [Display(Name = "Nome Action")]
        public string NomeAction { get; set; }

        [Display(Name = "Usuário")]
        [ForeignKey("Usuario")]
        [Column(Order = 1)]
        public string UserId { get; set; }
        public virtual Usuario ApplicationUser { get; set; }

    }
}
