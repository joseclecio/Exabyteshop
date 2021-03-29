using Entities.Entities.Enums;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Entities
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
        [Display(Name = "Endereço")]
        public string Endereco { get; set; }

        [MaxLength(450)]
        [Display(Name = "Complemento de Endereço")]
        public string ComplementoEndereco { get; set; }

        [MaxLength(20)]
        [Display(Name = "Celular")]
        public string Celular { get; set; }

        [MaxLength(20)]
        [Display(Name = "Telefone")]
        public string Telefone { get; set; }

        [Display(Name = "EnumEstadoCompra")]
        public bool Estado { get; set; }

        [Display(Name = "Tipo")]
        public TipoUsuario? Tipo { get; set; }
    }
}
