﻿using AutoMapper;
using Monatsziele.Api.Models;
using Monatsziele.Repository.EntityModels;

namespace Monatsziele.Api
{
    public class DomainProfile : Profile
    {
        public DomainProfile()
        {
            CreateMap<GoalEntity, Goal>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.RowKey));
        }
    }
}
