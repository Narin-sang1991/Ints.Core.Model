using System.ComponentModel;

namespace Ints.Core.Model.Enums
{
    public enum RoleLevelEnum : short
    {
        [Description("admin")]
        Admin = 0,

        [Description("system created")]
        SystemCreated = 1,

        [Description("user created")]
        UserCreated = 2,

        [Description("guest")]
        Guest = 3,
    }
}