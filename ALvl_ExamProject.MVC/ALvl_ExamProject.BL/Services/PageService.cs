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
    public class PageService: ShopService<PageBL, Page>, IPageService
    {
        public readonly IMapper _mapper;

        public PageService(IShopRepository<Page> repository, IMapper mapper) : base(repository)
        {
            _mapper = mapper;
        }

        public override PageBL Map(Page modelDL)
        {
            return _mapper.Map<PageBL>(modelDL);
        }

        public override Page Map(PageBL modelBL)
        {
            return _mapper.Map<Page>(modelBL);
        }

        public override IEnumerable<PageBL> Map(IList<Page> products)
        {
            return _mapper.Map<IEnumerable<PageBL>>(products);
        }

        public override IEnumerable<Page> Map(IList<PageBL> productsModel)
        {
            return _mapper.Map<IEnumerable<Page>>(productsModel);
        }
    }
}
