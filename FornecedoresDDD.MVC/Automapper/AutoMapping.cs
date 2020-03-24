using AutoMapper;
using FornecedoresDDD.Dominio.Entidades;
using FornecedoresDDD.MVC.Models;
using System.Collections.Generic;

namespace FornecedoresDDD.MVC.Automapper
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<Produto, ProdutoViewModel>();
        }
    }
}
