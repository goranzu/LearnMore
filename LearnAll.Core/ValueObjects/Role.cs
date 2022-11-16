using LearnAll.Core.Exceptions;

namespace LearnAll.Core.ValueObjects;

public sealed record Role
{
    public static IEnumerable<string> AvailableRoles = new[] { "teacher", "student", "admin" };
    public string Value { get; }

    public Role(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new InvalidRoleException(value);
        }

        if (!AvailableRoles.Contains(value))
        {
            throw new InvalidRoleException(value);
        }

        Value = value;
    }

    public static Role Teacher() => new Role("teacher");
    public static Role Student() => new Role("student");
    public static Role Admin() => new Role("Admin");

    public static implicit operator string(Role role) => role.Value;
    public static implicit operator Role(string role) => new(role);
}