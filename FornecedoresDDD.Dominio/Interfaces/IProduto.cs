using FornecedoresDDD.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace FornecedoresDDD.Dominio.Interfaces
{
    public interface IProduto : IBase<Produto>
    {
        //Herdando todos os métodos de IBase
    }
}
