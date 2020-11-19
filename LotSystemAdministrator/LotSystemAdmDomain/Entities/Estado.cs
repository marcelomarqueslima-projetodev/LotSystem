using System;
using System.Collections.Generic;
using System.Text;

namespace LotSystemAdmDomain.Entities
{
    public class Estado : EntityBase<int>
    {
        public string NomeEstado { get; set; }
        public string SiglasEstado { get; set; }
        public int PaisId { get; set; }
        public Pais Pais { get; set; }
    }
}
