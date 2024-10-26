using Data.Repositories.Interfaces;
using Data.Repositories.Interfaces;

namespace Data.UnitOfWork.Interfaces;

public interface IUnitOfWork
{
    public IRoleRepository Role { get; }

    void BeginTransaction();
    
    void Commit();
    
    void Rollback();
    
    void Dispose();
    
    Task<int> SaveChangesAsync();
}