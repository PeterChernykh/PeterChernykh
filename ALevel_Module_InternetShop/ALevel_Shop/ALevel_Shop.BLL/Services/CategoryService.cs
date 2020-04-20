using ALevel_Shop.BLL.ApiResponse;
using ALevel_Shop.BLL.ApiResponse.ApiResponseInterface;
using ALevel_Shop.BLL.ApiResponse.ApiResponseService;
using ALevel_Shop.BLL.Interfaces;
using ALevel_Shop.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALevel_Shop.BLL.Services
{
    public class CategoryService : CategoryApiService, ICategoryService
    {
        public CategoryService(ICategoryApiService apiService)
        {
        }
    }
}
