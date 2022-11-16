namespace LearnAll.Core.Exceptions;

public sealed class InvalidFullNameException : CustomException 
{
    public string Value { get; }

    public InvalidFullNameException(string value) : base($"Fullname: '{value}' is invalid.")
    {
        Value = value;
    }
}