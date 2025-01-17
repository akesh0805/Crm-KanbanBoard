using System.ComponentModel.DataAnnotations;

namespace Ilmhub.Spaces.Client.Models;

public class Lead
{
    public int Id { get; set; }
    [Required(ErrorMessage = "Ism Familiya to'ldirilishi shart")]
    public string? Name { get; set; }
    [Required(ErrorMessage = "Telefon no'mer yozilishi shart")]
    public string? Phone { get; set; }
    public LeadStatus Status { get; set; }
    public LeadSource Source { get; set; }
    public DateTime? CreatedAt { get; set; }
    public DateTime? ModifiedAt { get; set; }
    public string? Notes { get; set; }
    [Required]
    public Course? InterestedCourse { get; set; }
    public string? Reason { get; set; } // New property for Lost reason
    public bool IsHidden { get; set; }
}

public enum LeadStatus
{
    New,
    Phone,
    Contacted,
    Recontact,
    Incomplete,
    Registered,
    AttendedTrialLesson,
    Acquired,
    NotAcquired,
    Lost
}

public enum LeadSource
{
    Telegram,
    Instagram,
    Referral
}