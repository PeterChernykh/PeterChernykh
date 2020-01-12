using System;

namespace EnumarableALevel10012020
{
    public class Notebook//общая информация о ноотбуке, которая должна присутствовать 
    {
        public int SerialNumber { get; set; }
        public string Name { get; set; }

        public Notebook(int serialNumber, string name)
        {
            SerialNumber = serialNumber;
            Name = name;
        }
    }
}
