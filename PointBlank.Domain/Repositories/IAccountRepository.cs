namespace PointBlank.Domain.Repositories;

using Base;
using Entities;

public interface IAccountRepository : IRepository<Account>
{
    Task<Account?> GetByName(string name);
}