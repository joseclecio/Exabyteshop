using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using LojaVirtual.Models.Enum;
using Microsoft.AspNetCore.Identity;

namespace LojaVirtual.Models
{
    public class Usuario : IdentityUser
    {
        [MaxLength(50)]
        [Display(Name = "CPF")]
        public string CPF { get; set; }

        [Display(Name = "Idade")]
        public int Idade { get; set; }

        [MaxLength(255)]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [MaxLength(15)]
        [Display(Name = "CEP")]
        public string CEP { get; set; }

        [MaxLength(255)]
        [Display(Name = "Endereco")]
        public string Endereco { get; set; }

        [MaxLength(450)]
        [Display(Name = "ComplementoEndereço")]
        public string ComplementoEndereco { get; set; }

        [MaxLength(20)]
        [Display(Name = "Celular")]
        public string Celular { get; set; }

        [Column("Estado")]
        [Display(Name = "Estado")]
        public bool Estado { get; set; }

        [Display(Name = "Tipo")]
        public TipoUsuario? Tipo { get; set; }
    }
}
