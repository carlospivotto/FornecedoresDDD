using System;
using System.Collections.Generic;
using System.Text;

namespace FornecedoresDDD.Dominio.Entidades
{
    public class Produto : EntidadeBase
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }
    }
}
