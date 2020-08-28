using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ModeloDDD.MVC.ViewModels
{
    public class ClienteViewModel
    {
        [Key]
        public int ClienteId { get; set; }

        [Required(ErrorMessage ="Preencha o campo Nome")]
        [MaxLength(150, ErrorMessage ="Máximo {0} carateres")]
        [MinLength(2, ErrorMessage ="Minimo {0} carateres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Preencha o campo Sobrenome")]
        [MaxLength(150, ErrorMessage = "Máximo {0} carateres")]
        [MinLength(2, ErrorMessage = "Minimo {0} carateres")]
        public string SobreNome { get; set; }

        [Required(ErrorMessage = "Preencha o campo E-mail")]
        [MaxLength(100, ErrorMessage = "Máximo {0} carateres")]
        [EmailAddress(ErrorMessage = "Preencha um E-mail válido.")]
        [DisplayName("E-mail")]
        public string Email { get; set; }

        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }
        public virtual IEnumerable<ProdutoViewModel> Produtos { get; set; }
    }
}