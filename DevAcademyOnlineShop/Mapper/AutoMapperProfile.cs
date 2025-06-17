using AutoMapper;
using DevAcademyOnlineShop.Data;
using DevAcademyOnlineShop.View.Model.Models;


namespace DevAcademyOnlineShop.Mapper
{
    /// <summary>
    /// AutoMapperProfile: Use to map domain object ot View model and reverse map
    /// </summary>
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Product, ProductDto>();
        }


    }
}
