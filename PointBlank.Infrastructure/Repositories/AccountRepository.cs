namespace PointBlank.Infrastructure.Repositories;

using Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using PointBlank.Domain.Entities;

public class AccountRepository : Repository<Account>, IAccountRepository
{
    public async Task<Account?> GetByName(string name)
    {
        return await this.Table
            .Where(x => x.Name == name)
            .FirstOrDefaultAsync();
    }
}
