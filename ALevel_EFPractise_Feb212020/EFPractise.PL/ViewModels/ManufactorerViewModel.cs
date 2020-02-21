using System;

namespace EFPractise.PL.ViewModels
{
    public class ManufactorerViewModel
    {
        public int ContryId { get; set; }
        public string Name { get; set; }
        public long LicenseNumber { get; set; }
        public DateTime DataCreated { get; set; }
    }
}