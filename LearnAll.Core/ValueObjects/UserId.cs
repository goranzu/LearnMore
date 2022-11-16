using LearnAll.Core.Exceptions;

namespace LearnAll.Core.ValueObjects;

public record UserId
{
    public Guid Value { get; }

    public UserId(Guid value)
    {
        if (value == Guid.Empty)
        {
            throw new InvalidEntityIdException(value);
        }

        Value = value;
    }

    public static implicit operator string(UserId userId)
        => userId.ToString();

    public static implicit operator UserId(Guid userId)
        => new(userId);
};