using Ints.Core.Model.Enums;
using System.Text.Json.Serialization;

namespace Ints.Core.Model
{
    public record UserSaveDataModel
    {
        public Guid? UserId { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }
        public bool IsRequiredResetPassword { get; set; }

        [JsonIgnore]
        public AuthType? AuthType { get; set; }
    }
}
