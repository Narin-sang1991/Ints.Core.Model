using Ints.Core.Model.Enums;

namespace Ints.Core.Model;

public record OperationMemberDataModel
{
    public OperationMemberType MemberType { get; set; }
    public string? MemberTypeText { get; set; }
    public Guid ParentId { get; set; }
    public Guid ChildId { get; set; }
    public string? ChildName { get; set; }
}
