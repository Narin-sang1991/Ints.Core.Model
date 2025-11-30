using Ints.Core.Model.Enums;
using System.Text.Json.Serialization;

namespace Ints.Core.Model
{
    public record UserSaveData : UserManageData
    {
        public bool IsRequiredSavePassword { get; set; }

        [JsonIgnore]
        public AuthType? AuthType { get; set; }
    }
}
