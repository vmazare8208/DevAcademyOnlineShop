using AutoMapper;
using DevAcademyOnlineShop.View.Model.Models;
using DevAcademyOnlineShop.Data;
using Microsoft.AspNetCore.Mvc;

namespace DevAcademyOnlineShop.Controllers
{
    public class ProductController : ControllerBase
    {
        private readonly IMapper _mapper;
        public ProductController(IMapper mapper)
        {
            _mapper = mapper;
        }

        public void AddProduct(Product product)
        {
            // Logic to add product
            _mapper.Map<ProductDto>(product);
        }

    }
}
