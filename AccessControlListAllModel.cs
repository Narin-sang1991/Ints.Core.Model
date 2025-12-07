

using Ints.Core.Model.Enums;

namespace Ints.Core.Model;

public record AccessControlListAllModel
{
    public Guid OperationRoleId { get; init; }
    public OperationMemberType OperationMemberType { get; init; }
    public Guid? OperationChildId { get; init; }
    public string? OperationChildCode { get; init; }
    public ResourcePrincipalType ResourceType { get; init; }
    public string? ResourceRule { get; init; }
    public Guid? ResourceMappingId { get; init; }
}


public record AccessResourceListModel
{
    public Guid ResourceMappingId { get; init; }
    public ResourceMatchingType MatchingType { get; init; }
    //public MasterType MasterMappingType { get; init;}
}

