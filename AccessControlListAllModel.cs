

using Ints.Core.Model.Enums;

namespace Ints.Core.Model;

public record AccessControlListAllModel
{
    public OperationMemberType OperationMemberType { get; set; }
    public Guid? OperationChildId { get; set; }
    public string? OperationChildCode { get; set; }
    public ResourcePrincipalType ResourceType { get; set; }
    public string? ResourceRule { get; set; }
    public Guid? ResourceMappingId { get; set; }
}


public record AccessResourceListModel
{
    public Guid ResourceMappingId { get; set; }
    public ResourceMatchingType MatchingType { get; set; }
    //public MasterType MasterMappingType { get; set; }
}

