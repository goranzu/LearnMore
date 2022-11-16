using LearnAll.Core.Exceptions;

namespace LearnAll.Core.ValueObjects;

public sealed record Password
{
    public string Value { get; }

    public Password(string value)
    {
        if (string.IsNullOrWhiteSpace(value) || value.Length is < 5 or > 50)
        {
            throw new InvalidPasswordException();
        }
        
        Value = value;
    }

    public static implicit operator string(Password password) => password.Value;
    public static implicit operator Password(string password) => new(password);
}