using Ints.Core.Model.Enums;
using System.Text.Json.Serialization;

namespace Ints.Core.Model;

public record LoginRequest
{
    public string Login { get; init; }
    public string SecretValue { get; init; }
    public string Realm { get; init; }

    [JsonIgnore]
    public AuthType? AuthType { get; init; }
}
