using ALevel_InternetShop.BLL.Interfaces;
using ALevel_InternetShop.BLL.Models;
using ALevel_InternetShop.DAL.Interfaces;
using ALevel_InternetShop.DAL.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALevel_InternetShop.BLL.Services
{
    public class ProductService : ShopService<ProductModel, Product>, IProductService
    {

        public readonly IMapper _mapper;

        public ProductService(IShopRepository<Product> repository, IMapper mapper) : base(repository)
        {
            _mapper = mapper;
        }

        public override ProductModel Map(Product modelDL)
        {
            return _mapper.Map<ProductModel>(modelDL);
        }

        public override Product Map(ProductModel modelBL)
        {
            return _mapper.Map<Product>(modelBL);
        }

        public override IEnumerable<ProductModel> Map(IList<Product> products)
        {
            return _mapper.Map<IEnumerable<ProductModel>>(products);
        }

        public override IEnumerable<Product> Map(IList<ProductModel> productsModel)
        {
            return _mapper.Map<IEnumerable<Product>>(productsModel);
        }
    }
}
