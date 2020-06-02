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
    public class OrderDetailService : ShopService<OrderDetailBL, OrderDetail>, IOrderDetailService
    {
        public readonly IMapper _mapper;

        public OrderDetailService(IShopRepository<OrderDetail> repository, IMapper mapper) : base(repository)
        {
            _mapper = mapper;
        }

        public override OrderDetailBL Map(OrderDetail modelDL)
        {
            return _mapper.Map<OrderDetailBL>(modelDL);
        }

        public override OrderDetail Map(OrderDetailBL modelBL)
        {
            return _mapper.Map<OrderDetail>(modelBL);
        }

        public override IEnumerable<OrderDetailBL> Map(IList<OrderDetail> products)
        {
            return _mapper.Map<IEnumerable<OrderDetailBL>>(products);
        }

        public override IEnumerable<OrderDetail> Map(IList<OrderDetailBL> productsModel)
        {
            return _mapper.Map<IEnumerable<OrderDetail>>(productsModel);
        }
    }
}
