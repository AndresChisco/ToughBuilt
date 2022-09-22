using AutoMapper;

namespace Prueba.APP.Automapper
{
    public class MapperHelper
    {
        public static MapperConfiguration InitializeAutoMapper()
        {
            
            MapperConfiguration config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new AutoMapperProfile());
            });

            return config;
        }
    }
}