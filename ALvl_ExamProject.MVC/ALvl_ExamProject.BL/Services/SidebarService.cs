using ALvl_ExamProject.BL.Interfaces;
using ALvl_ExamProject.BL.Models;
using ALvl_ExamProject.DAL.Interfaces;
using ALvl_ExamProject.DAL.Models;
using AutoMapper;
using System.Collections.Generic;

namespace ALvl_ExamProject.BL.Services
{
    public class SidebarService: ShopService<SidebarBL, Sidebar>, ISidebarService
    {
        private readonly IMapper _mapper;

        public SidebarService(IShopRepository<Sidebar> repository, IMapper mapper): base(repository)
        {
            _mapper = mapper;
        }

        public override SidebarBL Map(Sidebar modelDL)
        {
            return _mapper.Map<SidebarBL>(modelDL);
        }

        public override Sidebar Map(SidebarBL modelBL)
        {
            return _mapper.Map<Sidebar>(modelBL);
        }

        public override IEnumerable<SidebarBL> Map(IList<Sidebar> products)
        {
            return _mapper.Map<IEnumerable<SidebarBL>>(products);
        }

        public override IEnumerable<Sidebar> Map(IList<SidebarBL> productsModel)
        {
            return _mapper.Map<IEnumerable<Sidebar>>(productsModel);
        }
    }
}
