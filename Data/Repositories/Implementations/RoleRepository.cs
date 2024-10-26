using Data.Repositories.Implementations;
using Data.Repositories.Interfaces;
using Domain.Context;
using Domain.Entities;
namespace Data.Repositories.Implementationss;

public class RoleRepository: Repository<Role>, IRoleRepository
{
    public RoleRepository(BilliardsContext context) : base(context)
    {
    }
}