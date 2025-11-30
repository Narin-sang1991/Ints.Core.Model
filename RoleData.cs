using Ints.Core.Model.Enums;

namespace Ints.Core.Model;

public record RoleData : OperationBaseData
{
    public RoleData() => IsRole = true;

    public RoleLevelEnum Level { get; init; } = RoleLevelEnum.Guest;
}
