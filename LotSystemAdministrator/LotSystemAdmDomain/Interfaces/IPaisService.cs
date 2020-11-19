using LotSystemAdmDomain.Entities;
using System.Collections.Generic;

namespace LotSystemAdmDomain.Interfaces
{
    public interface IPaisService
    {
        Pais Insert(Pais pais);
        Pais Update(Pais pais);
        void Delete(int id);
        Pais RecoverById(int id);
        IList<Pais> Browse();
    }
}
