

using Ints.Core.Model.Enums;

namespace Ints.Core.Model;

public record ResourcePrincipalRelationModel
{
    public Guid Id { get; set; }
    public ResourcePrincipalType Type { get; set; }
    public string? TypeText { get; set; }
    public string? ResourceName { get; set; }
    public string? Rule { get; set; }
    public Guid? ChildId { get; set; }
    public string? ChildName { get; set; }
}
