namespace PointBlank.Domain.Repositories.Base;

using Entities.Base;

public interface IRepository<TType> where TType : Entity
{
    Task<TType?> GetById(long id);

    Task<TType> CreateAsync(TType objeto);

    Task<TType> UpdateAsync(TType objeto);
}