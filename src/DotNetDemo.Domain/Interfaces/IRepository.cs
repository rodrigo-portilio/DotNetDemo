using DotNetDemo.Domain.Models;

namespace DotNetDemo.Domain.Interfaces;

public interface IRepository <T> : IUnityOfWork where T : Entity
{
    public Task<IEnumerable<T>> GetAllAsync();
    public Task<T> GetByIdAsync(Guid id);

    public void Update(T entity);
    
    public Task RemoveByIdAsync(Guid id);
}