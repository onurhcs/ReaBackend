using Infrastructure.Data.Postgres.Repositories.Interface;

namespace Infrastructure.Data.Postgres;

public interface IUnitOfWork : IDisposable
{
    IUserRepository Users { get; }
    IUserTokenRepository UserTokens { get; }
    IListRepository Lists { get; }
    ICommentsRepository Comments { get; }



    Task<int> CommitAsync();
}