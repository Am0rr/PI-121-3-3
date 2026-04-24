using PI.DAL.Entities;

namespace PI.DAL.Interfaces;

public interface IBaseRepository<T> where T : BaseEntity
{
    Task<T?> GetByIDAsync(Guid id);
    Task<IEnumerable<T>> GetAllAsync();
    Task<Guid> AddAsync(T item);
    void Update(T item);
    void Delete(T item);
}