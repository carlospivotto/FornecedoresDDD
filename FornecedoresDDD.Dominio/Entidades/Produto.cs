using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FornecedoresDDD.Dominio.Entidades
{
    public class Produto
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal Preco { get; set; }
    }
}
