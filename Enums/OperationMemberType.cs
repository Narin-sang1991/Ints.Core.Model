using System.ComponentModel;

namespace Ints.Core.Model.Enums;

public enum OperationMemberType
{
    [Description("Common Action")]
    CommonAction = 1,

    [Description("Event of Workflow")]
    WorkflowEvent = 2,

    [Description("Menu")]
    Menu = 3,
}
