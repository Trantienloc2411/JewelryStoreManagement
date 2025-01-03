using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Linq.Expressions;

namespace JSMRepositories;

public interface IGenericRepository<T> where T : class
{
    //CRU Basic
    ICollection<T> GetAll();
    ICollection<T> GetList(Expression<Func<T, bool>> expression);
    T Get(Expression<Func<T, bool>> expression);
    T Add(T entity);
    void AddRange(ICollection<T> entities);
    void Update(T entity);
    //void Delete(Guid id);
    void ClearTrackers();
    int SaveChanges();
    //This method will not use for any entity (except RefreshToken)
    void Remove(T entity);

    void Dispose();

    Task<T> GetSingleWithAsync(Expression<Func<T, bool>> expression);
    Task<EntityEntry<T>> AddSingleWithAsync(T entity);
    Task AddRangeWithAsync(ICollection<T> entities);
    Task UpdateWithAsync(T entity);
    Task SaveChangesAsync();


        //Employee
        Task<ICollection<T>> GetAllWithIncludeAsync(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties);


};
