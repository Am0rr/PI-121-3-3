using PI.DAL.Enums;

namespace PI.DAL.Entities.Identity;

public class User : BaseEntity
{
    public string Username { get; private set; } = null!;
    public string Email { get; private set; } = null!;
    public string PasswordHash { get; private set; } = null!;
    public UserRole Role { get; private set; }

    protected User() { }

    private User(string username, string email, string passwordHash, UserRole role = UserRole.Client)
    {
        Username = username;
        Email = email;
        PasswordHash = passwordHash;
        Role = role;
    }

    public static User Create(string username, string email, string passwordHash, UserRole role = UserRole.Client)
    {
        if (string.IsNullOrWhiteSpace(username))
            throw new ArgumentException("Username is required.", nameof(username));
        if (string.IsNullOrWhiteSpace(email))
            throw new ArgumentException("Email is required.", nameof(email));
        if (string.IsNullOrWhiteSpace(passwordHash))
            throw new ArgumentException("Password Hash is required", nameof(passwordHash));

        return new User(username, email, passwordHash, role);
    }
}