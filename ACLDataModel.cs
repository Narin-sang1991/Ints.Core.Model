

namespace Ints.Core.Model;

public record ACLManageDataModel
{ 
    public Guid ResourceId { get; set; }
    public string ResourceName { get; set; }
    public IEnumerable<OperationSearchDataModel> OperationList { get; set; }
}

public record ACLDataModel
{
    public Guid ResourceId { get; set; }
    public Guid OperationId { get; set; }
}

