using System.Collections.Generic;
using AutoMapper;

namespace ECommercial.Core.Utilities.Mappings
{
    public static class AutoMapperHelper
    {

        public static List<T> MapToSameTypeList<T>(List<T> list){
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<T,T>();
            });
            var mapper = config.CreateMapper();

            var result = mapper.Map<List<T>,List<T>>(list);
            return result;
        }
        
        public static T MapToSameType<T>(T obj){
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<T,T>();
            });
            var mapper = config.CreateMapper();

            var result = mapper.Map<T,T>(obj);
            return result;
        }

        public static MapperConfiguration CreateConfiguration(){
            var assemblies = new []{"ECommercial.Business"};

            var config = new MapperConfiguration(cfg=>{
                cfg.AddMaps(assemblies);
            });
            return config;
        }
    }
}