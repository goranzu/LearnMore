namespace LearnAll.Core.Exceptions;

public sealed class InvalidRoleException : CustomException
{
    public string Value { get; }

    public InvalidRoleException(string value) : base($"Role '{value}' is invalid.")
    {
        Value = value;
    }
}