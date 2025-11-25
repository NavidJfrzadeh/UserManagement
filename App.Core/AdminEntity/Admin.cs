namespace App.Core.AdminEntity;

public class Admin
{
    public int Id { get; init; }
    public string UserName { get; private set; }
    public string Email { get; private set; }
    public string PasswordHash { get; private set; }
    public DateTime CreatedAt { get; init; } = DateTime.UtcNow;

    public Admin(string userName, string email, string passwordHash)
    {
        UserName = userName;
        Email = email;
        PasswordHash = passwordHash;
    }
}
