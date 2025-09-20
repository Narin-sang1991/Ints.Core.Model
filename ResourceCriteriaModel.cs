

namespace Ints.Core.Model;

public record ResourceCriteriaModel
{
    public Guid? Id { get; set; }
    public Guid? ParentId { get; set; }
    public Guid? AppId { get; set; }
    public string? SearchText { get; set; }
}


