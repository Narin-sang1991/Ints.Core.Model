namespace Ints.Core.Model;

public record UserSearchData
{
    public Guid UserId { get; set; }
    public string Login { get; set; }
    public string Password { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public bool IsActive { get; set; } 
}

public record UserManageData
{
    public Guid? UserId { get; set; }
    public string Login { get; set; }
    public string Password { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public bool IsActive { get; set; } 
    public Guid RoleId { get; set; }
    public Guid[]? DealerIds { get; set; }
    public Guid[]? BeIds { get; set; }
}
