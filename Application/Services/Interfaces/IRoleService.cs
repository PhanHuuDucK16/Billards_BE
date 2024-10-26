using Domain.Entities;

namespace Application.Services.Interfaces;

public interface IRoleService
{
    ICollection<Role> GetRoles();
}