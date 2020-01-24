using FornecedoresDDD.Dominio.Entidades;
using FornecedoresDDD.Dominio.Interfaces.Produtos;
using FornecedoresDDD.Infra.Dados.Repositorio.Genericos;
using System;
using System.Collections.Generic;
using System.Text;

namespace FornecedoresDDD.Infra.Dados.Repositorio.Produtos
{
    public class ProdutoRepositorio : RepositorioBase<Produto>, ProdutoInterface
    {

    }
}
