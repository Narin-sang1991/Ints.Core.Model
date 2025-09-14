using Ints.Core.Model.Enums;

namespace Ints.Core.Model
{
    public record UserSaveDataModel
    {
        public Guid UserId { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }
        public AuthType? AuthType { get; set; }
        public bool IsRequiredResetPassword { get; set; }
    }
}
