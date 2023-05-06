using AutoMapper;
using GeekShopping.CartAPI.Model;
using GeekShopping.CartAPI.Data.ValueObjects;

namespace GeekShopping.CartAPI.Config
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductVO, Product>().ReverseMap();
                config.CreateMap<CartHeaderVO, CartHeader>().ReverseMap();
                config.CreateMap<CartDetailVO, CartDetail>().ReverseMap();
                config.CreateMap<CartDetailVO, CartDetail>().ReverseMap();
            });
            return mappingConfig;
        }
    }
}
