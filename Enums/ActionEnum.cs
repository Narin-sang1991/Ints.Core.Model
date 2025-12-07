using System.ComponentModel;

namespace Ints.Core.Model.Enums;

public enum ActionEnum : short
{
    [Description("*")]
    All = 0,

    [Description(nameof(View))]
    View = 1,

    [Description(nameof(Control))]
    Control = 2,

    [Description(nameof(Manage))]
    Manage = 3,

    [Description(nameof(EditSomeValue))]
    EditSomeValue = 10,
}