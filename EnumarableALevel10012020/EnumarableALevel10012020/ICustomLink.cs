using System;

namespace EnumarableALevel10012020
{
    public interface ICustomLink
    {
        void Add(int serialNumber, string name);
        Notebook this[int index] { get; }
        void Delete(Notebook value);
    }
}
