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
    public class Usuario //: IdentityUser
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UsuarioID { get; set; }
        public int CPF { get; set; }
        public int Idade { get; set; }

        [Required]
        [StringLength(50)]
        public string Nome { get; set; }
        public int Cep { get; set; }
        public string Endereco { get; set; }
        public string ComplementoEndereco { get; set; }

        [DataType(DataType.PhoneNumber)]
        public int Celular { get; set; }
        public bool Estado { get; set; }

        public TipoUsuario Tipo { get; set; }

        public ICollection<CompraUsuario> CompraUsuarios { get; set; }

        public ICollection<Produto> Produtos { get; set; }


    }
}
