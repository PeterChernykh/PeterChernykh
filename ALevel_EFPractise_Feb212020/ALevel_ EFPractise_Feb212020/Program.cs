using EFPractise.DAL.Repositories;
using EFPractise.PL.Controllers;

namespace ALevel__EFPractise_Feb212020
{
    class Program
    {
        static void Main(string[] args)
        {
            var jewController = new JewelleryController();

            jewController.Create(null);

            var jewRepo = new JewelleryRepository();

            jewRepo.GetAll();
        }
    }
}
