using Ints.Core.Model.Enums;

namespace Ints.Core.Model;

public record OperationDetailDataModel : OperationSearchDataModel
{
    public OperationDetailDataModel()
    {   }
    public OperationDetailDataModel(OperationSearchDataModel data)
    {
        Id = data.Id;
        Code = data.Code;
        Name = data.Name;
        IsRole = data.IsRole;
        AppModuleName = data.AppModuleName;
        AppName = data.AppName;
    }

    public OperationMemberType MemberType { get; set; }
    public Guid AppModuleId { get; set; }
    public List<OperationMemberDataModel>? OperationMembers { get; set; }
}

public record OperationSearchDataModel : OperationBaseData
{
    public string? AppName { get; set; }
    public string? AppModuleName { get; set; }
}

public abstract record OperationBaseData
{
    public Guid? Id { get; set; }
    public string Code { get; set; }
    public string? Name { get; set; }
    public bool IsRole { get; set; }
}
