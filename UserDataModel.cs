namespace Ints.Core.Model
{
    public record UserManageData
    {
        public Guid UserId { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; } 
    }
}
