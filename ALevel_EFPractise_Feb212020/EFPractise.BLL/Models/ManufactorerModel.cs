using System;

namespace EFPractise.BLL.Models
{
    public class ManufactorerModel
    {
        public int Id { get; set; }
        public int ContryId { get; set; }
        public string Name { get; set; }
        public long LicenseNumber { get; set; }
        public DateTime DataCreated { get; set; }
    }
}
