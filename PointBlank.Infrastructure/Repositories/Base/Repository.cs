namespace PointBlank.Infrastructure.Repositories;

using Database;
using Domain.Entities.Base;
using Microsoft.EntityFrameworkCore;

public abstract class Repository<TType> : MysqlContext where TType : Entity
{
    public virtual DbSet<TType> Table { get; set; }

    public virtual async Task<TType?> GetById(long id)
    {
        return await this.Table
            .Where(x => x.Id == id)
            .FirstOrDefaultAsync();
    }

    public virtual async Task<TType> CreateAsync(TType objeto)
    {
        // Salvar
        await this.Table.AddAsync(objeto);

        // Salvar
        await this.SaveChangesAsync();

        // Retorno
        return objeto;
    }

    public virtual async Task<TType> UpdateAsync(TType objeto)
    {
        // Atualizar controles
        this.Table.Update(objeto);

        // Salvar
        await this.SaveChangesAsync();

        // Retorno
        return objeto;
    }
}