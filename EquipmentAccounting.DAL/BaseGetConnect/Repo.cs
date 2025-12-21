using EA_DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA_DAL.BaseGetConnect
{
    public class Repo<T> where T : class
    {
        private readonly AllDbForItContext _db;
        private readonly DbSet<T> _set;



        public Repo(AllDbForItContext db)
        {
            _db = db;
            _set = db.Set<T>();
        }

        public List<T> GetAll() => _set.ToList();

        public T GetById(int id) => _set.Find(id);

        public void Add(T item) => _set.Add(item);

        public void Update(T item) => _set.Update(item);

        public void Delete(T item) => _set.Remove(item); 

        public void Save() => _db.SaveChanges();

    }
}
