using LotSystemAdmDomain.Entities;
using LotSystemAdmDomain.Interfaces;
using LotSystemAdmInfraData.Context;
using System.Collections.Generic;

namespace LotSystemAdmInfraData.Repository
{
    public class PaisRepository : BaseRepository<Pais, int>, IPaisRepository
    {
        public PaisRepository(LotSystemContext context) : base(context)
        {
        }

        public IList<Pais> GetAll() => base.Select();

        public Pais GetById(int id) => base.Select(id);

        public void Remove(int id)
        {
            base.Delete(id);
        }

        public void Save(Pais pais)
        {
            if(pais.Id == 0)
            {
                base.Insert(pais);
            }
            else
            {
                base.Update(pais);
            }
        }
    }
}
