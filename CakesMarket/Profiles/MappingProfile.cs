using AutoMapper;
using CakesMarket.Models.Model;
using CakesMarket.Models.VIewModel;

namespace CakesMarket.Web.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            AllowNullCollections = true;
            CreateMap<Cake, CakeViewModel>()
                .ForMember(f => f.Categoty, opt => opt.MapFrom(m => m.Category.Name))
                .ForMember(f => f.Ingredients, ing => ing.MapFrom(m => string.Join(',', m.Ingredients)));
        }
    }
}
