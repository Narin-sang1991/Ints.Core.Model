namespace Ints.Core.Model;

public record MenuDataWithChildModel : MenuDataModel
{
    public MenuDataWithChildModel(MenuDataModel baseModel)
    {
        Id = baseModel.Id;
        ParentId = baseModel.ParentId;
        Ordinal = baseModel.Ordinal;
        Label = baseModel.Label;
        Title = baseModel.Title;
        Description = baseModel.Description;
        RoutePath = baseModel.RoutePath;
        IconUI = baseModel.IconUI;
        IconFilePath = baseModel.IconFilePath;
        Breadcrumb = baseModel.Breadcrumb;
    }
    public IEnumerable<MenuDataModel>? Childs { get; init; } 
}

public record MenuDataModel
{
    public Guid Id { get; init; }
    public Guid? ParentId { get; init; }
    public byte Ordinal { get; init; }
    public string Label { get; init; }
    public string? Title { get; init; }
    public string? Description { get; init; }
    public string? RoutePath { get; init; }
    public string? IconUI { get; init; }
    public string? IconFilePath { get; init; }
    public string? Breadcrumb { get; init; }
}
