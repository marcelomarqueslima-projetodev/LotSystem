using LotSystemAdmDomain.Entities;
using System.Collections.Generic;

namespace LotSystemAdmDomain.Interfaces
{
    public interface IPaisRepository
    {
        void Save(Pais pais);
        void Remove(int id);
        Pais GetById(int id);
        IList<Pais> GetAll();
    }
}
