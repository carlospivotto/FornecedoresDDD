using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FornecedoresDDD.Dominio.Entidades
{
    public abstract class EntidadeBase
    {
        [Display(Name = "Id")]
        public Guid Id { get; set; }
    }
}
