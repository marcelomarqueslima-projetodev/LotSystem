using LotSystemAdmDomain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace LotSystemAdmDomain.Interfaces
{
    public interface IEstadoRepository
    {
        void Save(Estado estado);
        void Remove(int id);
        Estado GetById(int id);
        IList<Estado> GetAll();
    }
}
