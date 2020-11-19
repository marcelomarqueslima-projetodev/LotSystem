using LotSystemAdmDomain.Entities;
using LotSystemAdmInfraData.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LotSystemAdmInfraData.Repository
{
    public class BaseRepository<T, B> where T : EntityBase<B>
    {
        protected readonly LotSystemContext _context;

        public BaseRepository(LotSystemContext context)
        {
            _context = context;
        }

        protected virtual void Insert(T obj)
        {
            _context.Set<T>().Add(obj);
            _context.SaveChanges();
        }

        protected virtual void Update(T obj)
        {
            _context.Entry(obj).State = EntityState.Modified;
            _context.SaveChanges();
        }

        protected virtual void Delete(int id)
        {
            _context.Set<T>().Remove(Select(id));
            _context.SaveChanges();
        }

        protected virtual T Select(int id) => _context.Set<T>().Find(id);

        protected virtual IList<T> Select () => _context.Set<T>().ToList();
    }
}
