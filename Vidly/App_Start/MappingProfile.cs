using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Vidly.Dtos;
using Vidly.Models;

namespace Vidly.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Customer, CustomerDTO>();
            CreateMap<CustomerDTO, Customer>();

            CreateMap<Movie, MovieDTO>();
            CreateMap<MovieDTO, Movie>();

            CreateMap<MembershipType, MembershipTypeDTO>();
            CreateMap<MembershipTypeDTO, MembershipType>();

            CreateMap<Genre,GenreDTO>();
            CreateMap<GenreDTO, Genre>();
        }
    }
}