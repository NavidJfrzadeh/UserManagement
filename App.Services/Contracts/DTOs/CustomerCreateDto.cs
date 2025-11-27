namespace App.Services.Contracts.DTOs
{
    public class CustomerCreateDto
    {
        public required string FullName { get; set; }
        public required string Email { get; set; }
    }
}