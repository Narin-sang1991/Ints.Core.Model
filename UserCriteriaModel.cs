namespace Ints.Core.Model
{
    public record UserCriteria
    {
        public Guid? UserId { get; set; }
        public string? Login { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public bool? IsActive { get; set; }
    }
}
