using ALvl_ExamProject.BL.Interfaces;
using ALvl_ExamProject.BL.Models;
using ALvl_ExamProject.DAL.Interfaces;
using ALvl_ExamProject.DAL.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALvl_ExamProject.BL.Services
{
    public class ProductService : ShopService<ProductBL, Product>, IProductService
    {

        public readonly IMapper _mapper;

        public ProductService(IShopRepository<Product> repository, IMapper mapper) : base(repository)
        {
            _mapper = mapper;
        }

        public override ProductBL Map(Product modelDL)
        {
            return _mapper.Map<ProductBL>(modelDL);
        }

        public override Product Map(ProductBL modelBL)
        {
            return _mapper.Map<Product>(modelBL);
        }

        public override IEnumerable<ProductBL> Map(IList<Product> products)
        {
            return _mapper.Map<IEnumerable<ProductBL>>(products);
        }

        public override IEnumerable<Product> Map(IList<ProductBL> productsModel)
        {
            return _mapper.Map<IEnumerable<Product>>(productsModel);
        }
    }
}
