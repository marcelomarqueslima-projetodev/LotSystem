﻿namespace LotSystemAdmDomain.Entities
{
    public abstract class EntityBase<T>
    {
        public virtual T Id { get; set; }
    }
}
