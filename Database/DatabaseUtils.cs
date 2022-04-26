using FitnessApp.Database.Models;
using Microsoft.EntityFrameworkCore;

namespace FitnessApp.Database
{
    public class DatabaseUtils<T> where T : ID
    {
        private readonly FitnessAppDbContext _context;
        private readonly DbSet<T> _dbSet;

        public DatabaseUtils(FitnessAppDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public T GetElement(Func<DbSet<T>, T> selectionFunction)// function example: (dbSet) => dbSet.Where(...)
        {
            T element = selectionFunction(_dbSet);
            return element;
        }

        public T AddElement(T element)
        {
            _dbSet.Add(element);
            _context.SaveChanges();
            return GetElement((dbSet) => dbSet.FirstOrDefault(x => x.Id == dbSet.Max(x => x.Id)));
        }

        public T UpdateElement(int id, T updatedElement)
        {
            T oldElement = GetElement((dbSet) => dbSet.FirstOrDefault(x => x.Id == id));
            _context.Entry(oldElement).State = EntityState.Detached;
            updatedElement.Id = oldElement.Id;
            _dbSet.Update(updatedElement);
            _context.SaveChanges();
            _context.Entry(updatedElement).State = EntityState.Modified;
            return GetElement((dbSet) => dbSet.FirstOrDefault(x => x.Id == id));
        }

        public T DeleteElement(int id)
        {
            T oldElement = GetElement((dbSet) => dbSet.FirstOrDefault(x => x.Id == id));
            _context.Entry(oldElement).State = EntityState.Detached;
            _dbSet.Remove(oldElement);
            _context.SaveChanges();
            _context.Entry(oldElement).State = EntityState.Deleted;
            return oldElement;
        }
    }
}
