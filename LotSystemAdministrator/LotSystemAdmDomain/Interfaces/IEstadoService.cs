using LotSystemAdmDomain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace LotSystemAdmDomain.Interfaces
{
    public interface IEstadoService
    {
        Estado Insert(Estado estado);
        Estado Update(Estado estado);
        void Delete(int id);
        Estado RecoverById(int id);
        IList<Estado> Browse();
    }
}
