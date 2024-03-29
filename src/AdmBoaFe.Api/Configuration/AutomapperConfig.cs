﻿using AutoMapper;
using AdmBoaFe.Api.Configuration;
using AdmBoaFe.Api.ViewModels;
using Microsoft.EntityFrameworkCore.Metadata;
using AdmBoaFe.Business.Models;

namespace AdmBoaFe.Api.Configuration
{
    public class AutomapperConfig : Profile
    {
        public AutomapperConfig()
        {
            CreateMap<Condominio, CondominioViewModel>().ReverseMap();
            CreateMap<ImovelViewModel, Imovel>();

            CreateMap<ImovelImagemViewModel, IModel>().ReverseMap();

            CreateMap<Imovel, ImovelViewModel>()
                .ForMember(dest => dest.Nome, opt => opt.MapFrom(src => src.Nome));
        }
    }
}
