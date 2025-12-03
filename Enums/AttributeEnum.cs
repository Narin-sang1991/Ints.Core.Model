using System.ComponentModel;

namespace Ints.Core.Model.Enums
{
    public enum AttributeEnum : short
    {
        [Description("dealer")]
        Dealer = 10,

        [Description("business entity")]
        BusinessEntity = 20,
    }
}