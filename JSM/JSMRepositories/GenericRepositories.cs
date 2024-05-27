using System.Linq.Expressions;
using DataLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

#pragma warning disable
namespace JSMRepositories;

public class GenericRepositories<T> : IGenericRepository<T> where T : class
    {
        private readonly JSMDbContext _context;
        private readonly DbSet<T> _dbSet;

        public GenericRepositories(JSMDbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public virtual ICollection<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public ICollection<T> GetList(Expression<Func<T, bool>> expression)
        {
            return _dbSet.Where(expression).ToList();
        }

        public virtual T Get(Expression<Func<T, bool>> expression)
        {
            return _dbSet.FirstOrDefault(expression);
        }

        public virtual T Add(T entity)
        {
            _dbSet.Add(entity);
            return entity;
        }

        public void AddRange(ICollection<T> entities)
        {
            _dbSet.AddRange(entities);
        }

        public virtual void Update(T entity)
        {
            _dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }
        
        public void ClearTrackers()
        {
            _context.ChangeTracker.Clear();
        }
        public virtual int SaveChanges()
        {
            try
            {
                return _context.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                // Handle or log the exception
                throw new Exception(ex.Message);
            }
        }
        public virtual void Remove(T entity)
        {

            _dbSet.Remove(entity);
        }

        public async Task UpdateWithAsync(T entity)
        {
            _dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public virtual async Task SaveChangesAsync()
        {
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException ex)
            {
                // Handle or log the exception
                throw new Exception(ex.Message);
            }
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public async Task<ICollection<T>> GetAllWithAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<ICollection<T>> GetListWithAsync(Expression<Func<T, bool>> expression)
        {
            return await _dbSet.Where(expression).ToListAsync();
        }


        public async Task<T> GetSingleWithAsync(Expression<Func<T, bool>> expression)
        {
            return await _dbSet.FirstOrDefaultAsync(expression);
        }

        public async Task<EntityEntry<T>> AddSingleWithAsync(T entity)
        {
            return await _dbSet.AddAsync(entity);
        }

        public async Task AddRangeWithAsync(ICollection<T> entities)
        {
            await _dbSet.AddRangeAsync(entities);
        }

        public IEnumerable<T> GetAllTest()
        {
            return _context.Set<T>().AsNoTracking().ToList();
        }
        
        
    }
