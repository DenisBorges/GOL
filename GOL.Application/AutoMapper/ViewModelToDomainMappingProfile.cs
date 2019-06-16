using AutoMapper;
using GOL.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace GOL.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile:Profile
    {
        //public ViewModelToDomainMappingProfile()
        //{
        //    CreateMap<AirplaneViewModel, Airplane>();
        //}
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappingProfile"; }

        }

        protected override void Configure()
        {
            Mapper.CreateMap<AirplaneViewModel,Airplane>();
        }
    }
}
