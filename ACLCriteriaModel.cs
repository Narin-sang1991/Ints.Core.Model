

namespace Ints.Core.Model;

public record ACLCriteriaModel
{
    public Guid? Id { get; set; }
    public Guid? ResourceId { get; set; }
    public string? SearchText { get; set; }
}


