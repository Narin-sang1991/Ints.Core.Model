

using Ints.Core.Model.Enums;

namespace Ints.Core.Model;

public record ResourceDetailDataModel : ResourceSearchDataModel
{
    public ResourceDetailDataModel()
    { }
    public ResourceDetailDataModel(ResourceSearchDataModel data)
    {
        Id = data.Id;
        Name = data.Name;
        ParentId = data.ParentId;
        ParentName = data.ParentName;
        AppId = data.AppId;
        AppName = data.AppName;
    } 
    public List<ResourcePrincipalRelationModel>? PrincipalRelations { get; set; } = new List<ResourcePrincipalRelationModel>();
}

public record ResourceSearchDataModel : ResourceBaseData
{
    public string? ParentName { get; set; }
    public string? AppName { get; set; }
    public RoleLevelEnum Level { get; init; } = RoleLevelEnum.Guest;
}

public abstract record ResourceBaseData
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public Guid? ParentId { get; set; }
    public Guid? AppId { get; set; }
}
