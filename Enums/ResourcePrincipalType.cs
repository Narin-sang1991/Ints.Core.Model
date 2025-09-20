using System.ComponentModel;

namespace Ints.Core.Model.Enums;

public enum ResourcePrincipalType
{
    [Description("Rule")]
    Rule = 1,

    [Description("User Group")]
    UserGroup = 2,

    [Description("Internal User")]
    InternalUser = 3,

    [Description("External User")]
    ExternalUser = 4,
}
