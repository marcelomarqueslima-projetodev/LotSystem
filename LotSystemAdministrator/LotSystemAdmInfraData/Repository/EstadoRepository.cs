using LotSystemAdmDomain.Entities;
using LotSystemAdmDomain.Interfaces;
using LotSystemAdmInfraData.Context;
using System.Collections.Generic;

namespace LotSystemAdmInfraData.Repository
{
    public class EstadoRepository : BaseRepository<Estado, int>, IEstadoRepository
    {
        public EstadoRepository(LotSystemContext context) : base(context)
        {
        }

        public IList<Estado> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Estado GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Save(Estado estado)
        {
            throw new System.NotImplementedException();
        }
    }
}
