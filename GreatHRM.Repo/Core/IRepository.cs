using GreatHRM.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GreatHRM.Repo.Core
{
    public interface IRepository<T> where T : Entity
    {
        void Add(T item);
        void Update(T entityToUpdate);

        IEnumerable<T> GetAll();
        IEnumerable<T> GetAll(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = "", bool isTrackingOff = false);
        IEnumerable<T> GetAll(out int total, out int totalDisplay, Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = "", int pageIndex = 1, int pageSize = 10, bool isTrackingOff = false);

        int GetCount(Expression<Func<T, bool>> filter = null);

        T GetById(int id);
        T GetById(object id, string includeProperties = "");
     
        void Disable(int id);
        void Disable(T item);

        void DeleteFromDb(Expression<Func<T, bool>> filter);
        void DeleteFromDb(object id);
        void DeleteFromDb(T entityToDelete);
    }
}
