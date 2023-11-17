using Phase3Section2._21.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Phase3Section2._21.Repository
{
    public class GenericRepository<t> : IGenericRepository<t> where t : class
    {
        private School1Entities1 db = null;
        private DbSet<t> table = null;
        public GenericRepository()
        {
            this.db = new School1Entities1();
            table = db.Set<t>();
        }
        public GenericRepository(School1Entities1 db)
        {
            this.db = db;
            table = db.Set<t>();
        }
        public IEnumerable<t> SelectAll()
        {
            return table.ToList();
        }
        public t SelectByID(object id)
        {
            return table.Find(id);
        }
        public void Insert(t obj)
        {
            table.Add(obj);
        }
        public void Update(t obj)
        {
            table.Attach(obj);
            db.Entry(obj).State = EntityState.Modified;
        }
        public void Delete(object id)
        {
            t existing = table.Find(id);
            table.Remove(existing);
        }
        public void Save()
        {
            db.SaveChanges();
        }
    }

}