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
    public class OrderService : ShopService<OrderBL, Order>, IOrderService
    {
        public readonly IMapper _mapper;

        public OrderService(IShopRepository<Order> repository, IMapper mapper) : base(repository)
        {
            _mapper = mapper;
        }

        public override OrderBL Map(Order modelDL)
        {
            return _mapper.Map<OrderBL>(modelDL);
        }

        public override Order Map(OrderBL modelBL)
        {
            return _mapper.Map<Order>(modelBL);
        }

        public override IEnumerable<OrderBL> Map(IList<Order> products)
        {
            return _mapper.Map<IEnumerable<OrderBL>>(products);
        }

        public override IEnumerable<Order> Map(IList<OrderBL> productsModel)
        {
            return _mapper.Map<IEnumerable<Order>>(productsModel);
        }
    }
}
