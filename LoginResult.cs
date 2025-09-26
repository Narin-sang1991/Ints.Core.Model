namespace Ints.Core.Model;

public enum LoginResultCode
{
    Success = 1,
    Invalid = 2,
    PasswordExpire = 3,
    RequiredOU = 4,
    NotActivated = 5
};

public record LoginResult
{
    public LoginResultCode Code { get; init; }
    public string Text { get { return Code.ToString(); } }
    public Guid Id { get; init; }
    public string Name { get; init; }
    public object Token { get; init; }
    public string SourceIP { get; init; }
}
