using EFPractise.DAL.IRepositories;
using EFPractise.DAL.Models;

namespace EFPractise.DAL.Repositories
{
    public class JewelleryRepository: IJewelleryRepository
    {
        private readonly JewelleryContext _ctx;

        public JewelleryRepository()
        {
            _ctx = new JewelleryContext();
        }

        public void Create (Jewellery model)
        {
            _ctx.Jewelleries.Add(model);
            _ctx.SaveChanges();
        }


    }
}
