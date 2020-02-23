using EFPractise.DAL.IRepositories;
using EFPractise.DAL.Models;
using System;
using System.Collections.Generic;

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

        public IEnumerable<Jewellery> GetAll()
        {
            var allJew = _ctx.Jewelleries;
            return allJew;
        }


    }
}
