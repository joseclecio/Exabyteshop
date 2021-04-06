using Entities.Notifications;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Entities
{

    public class Produto : Notifies
    {
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        [MaxLength(255)]
        public string Nome { get; set; }

        [Display(Name = "Descrição")]
        [MaxLength(150)]
        public string Descricao { get; set; }

        [Display(Name = "Observação")]
        [MaxLength(20000)]
        public string Observacao { get; set; }

        [Display(Name = "Valor")]
        public decimal Valor { get; set; }

        [Display(Name = "Quantidade Estoque")]
        public int QuantidadeEstoque { get; set; }

        [Display(Name = "Usuário")]
        [ForeignKey("Usuario")]
        [Column(Order = 1)]
        public string UserId { get; set; }
        public virtual Usuario Usuario { get; set; }


        [Display(Name = "Estado")]
        public bool Estado { get; set; }

        [Display(Name = "Data de Cadastro")]
        public DateTime DataCadastro { get; set; }

        [Display(Name = "Data de Alteração")]
        public DateTime DataAlteracao { get; set; }

        [NotMapped]
        public int IdProdutoCarrinho { get; set; }

        [NotMapped]
        public int QtdCompra { get; set; }

        [NotMapped]
        public IFormFile Imagem { get; set; }

        public string Url { get; set; }

        [NotMapped]
        public DateTime? DataCompra { get; set; }
    }
}
