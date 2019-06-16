using AutoMapper;
using GOL.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace GOL.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile:Profile
    {
        //public DomainToViewModelMappingProfile()
        //{
        //    CreateMap<Airplane, AirplaneViewModel>();
        //}

        public override string ProfileName
        {
            get { return "DomainToViewModelMappingProfile"; }

        }

        protected override void Configure()
        {
            Mapper.CreateMap<Airplane, AirplaneViewModel>();
        }
    }
}
