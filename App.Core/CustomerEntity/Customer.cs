namespace App.Core.CustomerEntity;

public class Customer
{
    public Customer(string fullName, string email)
    {
        FullName = fullName;
        Email = email;
        CreatedAt = DateTime.UtcNow;
    }

    public int Id { get; init; }
    public string FullName { get; set; }
    public string Email { get; private set; }
    public DateTime CreatedAt { get; init; }
}
