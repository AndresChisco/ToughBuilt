using Prueba.APP.Models.ViewModels;
using Prueba.Entity;
using AutoMapper;

namespace Prueba.APP.Automapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Product, ProductViewModel>().ReverseMap();
        }
    }
}