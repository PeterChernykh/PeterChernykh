using System;

namespace EFPractise.DAL.Models
{
    public class Manufacturer
    {
        public int Id { get; set; }
        public int ContryId { get; set; }
        public string Name { get; set; }
        public long LicenseNumber { get; set; }
        public DateTime DataCreated { get; set; }
    }
}
