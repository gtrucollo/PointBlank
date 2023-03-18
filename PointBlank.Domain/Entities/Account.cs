namespace PointBlank.Domain.Entities;

using Base;

public class Account : Entity
{
    public Account(string name, string password)
    {
        this.Name = name;
        this.Password = password;
        this.Status = StatusEnum.Active;
    }

    public enum StatusEnum
    {
        Inactive = 0,
        Active = 1,
        Suspended = 2,
    }

    public StatusEnum Status { get; set; }

    public string Name { get; set; }

    public string Password { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;

    public DateTime UpdatedAt { get; set; } = DateTime.Now;
}