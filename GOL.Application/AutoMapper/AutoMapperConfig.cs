using AutoMapper;
using GOL.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace GOL.Application.AutoMapper
{
    public sealed class AutoMapperConfig
    {
        public static void RegisterMapping()
        {
            Mapper.Initialize(m =>
            {
                m.AddProfile<DomainToViewModelMappingProfile>();
                m.AddProfile<ViewModelToDomainMappingProfile>();
            });
        }
    }
}
