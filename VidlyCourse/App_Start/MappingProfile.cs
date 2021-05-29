using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VidlyCourse.Models;
using VidlyCourse.Dtos;

namespace VidlyCourse.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Domain To Dto
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<MembershipType, MembershipTypeDto>();
            
            
            // Dto To Domain
            Mapper.CreateMap<CustomerDto, Customer>();
            Mapper.CreateMap<MembershipTypeDto, MembershipType>();

        }
    }
}