using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALvl_ExamProject.BL.Interfaces
{
    public interface IShopService<ModelBL> where ModelBL : class
    {
        void Add(ModelBL model);
        void Remove(int id);
        void Update(ModelBL model);
        ModelBL GetById(int id);
        IEnumerable<ModelBL> GetAll();
    }
}
