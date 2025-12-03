using Ints.Core.Model.Enums;

namespace Ints.Core.Model;

public record UserSearchData
{
    public Guid UserId { get; init; }
    public string Login { get; init; }
    public string Password { get; init; }
    public string Name { get; init; }
    public string Email { get; init; }
    public bool IsActive { get; init; }
}

public record UserManageData
{
    public Guid? UserId { get; init; }
    public string Login { get; init; }
    public string Password { get; init; }
    public string Name { get; init; }
    public string Email { get; init; }
    public bool IsActive { get; init; }
    public Guid? RoleId { get; init; }
    public RoleLevelEnum? RoleLevel { get; init; }
    public Guid[]? DealerIds { get; init; }
    public Guid[]? BeIds { get; init; }
}
