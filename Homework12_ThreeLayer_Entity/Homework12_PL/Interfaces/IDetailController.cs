using Homework12_PL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework12_PL.Interfaces
{
    public interface IDetailController
    {
        IEnumerable<DetailViewModel> GetAll();
    }
}
