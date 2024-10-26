using Application.Services.Interfaces;
using Data.Repositories.Interfaces;
using Data.UnitOfWork.Interfaces;
using Domain.Entities;

namespace Application.Services.Implementations;

public class RoleService: IRoleService
{
    private readonly IRoleRepository _roleRepository;

    public RoleService(IUnitOfWork unitOfWork)
    {
        _roleRepository = unitOfWork.Role;
    }

    public ICollection<Role> GetRoles()
    {
        var roles = _roleRepository.GetAll().ToList();
        return roles;
    }
}