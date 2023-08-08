using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.EntityFramework;
using Infrastructure.Data.Postgres.Repositories.Base;
using Infrastructure.Data.Postgres.Repositories.Base.Interface;
using Infrastructure.Data.Postgres.Repositories.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.Repositories;

public class ListRepositories : Repository<List, int>, IListRepository
{
    public ListRepositories(PostgresContext postgresContext) : base(postgresContext)
    {
    }

    public async Task<IList<List>> GetAllAsync(Expression<Func<List, bool>>? filter = null)
    {
        var Cards = PostgresContext.Set<List>();
        return filter == null
            ? await Cards.ToListAsync()
            : await Cards.Where(filter).ToListAsync();
    }
    public Task<IList<List>> GetByContactIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public void Update(List entity)
    {
        PostgresContext.Set<List>().Update(entity);
        PostgresContext.SaveChanges();
    }
    async Task<List> IRepository<List, int>.GetByIdAsync(int id)
    {
        return await PostgresContext.Set<List>().FindAsync(id);
    }

    public async Task AddAsync(List entity)
    {
        await PostgresContext.Set<List>().AddAsync(entity);
        await PostgresContext.SaveChangesAsync();
    }
}

