using CreditBoss.Enums;

namespace CreditBoss.Dto;

public class ClientDto
{
    public int Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Email { get; set; }
    public string? Phone { get; set; }
    public string? Address { get; set; }
    public DateTime Birthdate { get; set; }
    public string? IdentificationNumber { get; set; }
    public string? Status { get; set; }
}