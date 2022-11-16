using LearnAll.Core.Exceptions;

namespace LearnAll.Core.ValueObjects;

public sealed record Username
{
    public string Value { get; }

    public Username(string value)
    {
        if (string.IsNullOrWhiteSpace(value) || value.Length is < 3 or > 30)
        {
            throw new InvalidUsernameException(value);
        }

        Value = value;
    }

    public static implicit operator string(Username username) => username.Value;
    public static implicit operator Username(string username) => new(username);
}