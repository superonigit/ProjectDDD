using AutoMapper;
using ProjectDDD.Domain.Entities;
using ProjectDDD.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectDDD.UI.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
       public DomainToViewModelMappingProfile()
        {
            CreateMap<Cliente, ClienteViewModel>();
            CreateMap<Produto, ProdutoViewModel>();
        }
    }
}