namespace Ints.Core.Model;
public record AccessPermissionModel
{
    public string Feature { get; init; }
    public IEnumerable<string> Actions { get; init; }
}
