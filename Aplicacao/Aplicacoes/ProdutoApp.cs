using Aplicacao.Interfaces;
using FornecedoresDDD.Dominio.Entidades;
using FornecedoresDDD.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aplicacao.Aplicacoes
{
    public class ProdutoApp : IProdutoApp
    {
        IProduto _produtoInterface;

        public ProdutoApp(IProduto produtoInterface)
        {
            _produtoInterface = produtoInterface;
        }

        public void Adicionar(Produto obj)
        {
            _produtoInterface.Adicionar(obj);
        }

        public void Atualizar(Produto obj)
        {
            _produtoInterface.Atualizar(obj);
        }

        public void Excluir(Produto obj)
        {
            _produtoInterface.Excluir(obj);
        }

        public IList<Produto> Listar()
        {
            return _produtoInterface.Listar();
        }

        public Produto RecuperarPorId(Guid id)
        {
            return _produtoInterface.RecuperarPorId(id);
        }
    }
}
