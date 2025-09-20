using Ints.Core.Model.Enums;

namespace Ints.Core.Model;

public record OperationCriteriaModel
{
    public Guid? Id { get; set; }
    public Guid? AppId { get; set; }
    public Guid? AppModuleId { get; set; }
    public bool? IsRole { get; set; }
    public OperationMemberType? Type { get; set; }
    public OperationMemberType? IgnoreType { get; set; }
    public string? SearchText { get; set; }
}


