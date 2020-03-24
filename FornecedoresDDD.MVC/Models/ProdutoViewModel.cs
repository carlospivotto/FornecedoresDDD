using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FornecedoresDDD.MVC.Models
{
    public class ProdutoViewModel
    {
        public Guid Id { get; set; }
        [Display(Name = "Nome")]
        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        public string Nome { get; set; }
        [Display(Name = "Preço")]
        [Required(ErrorMessage = "O campo Preço é obrigatório.")]
        public decimal Preco { get; set; }
    }
}
