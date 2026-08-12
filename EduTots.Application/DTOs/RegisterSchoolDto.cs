namespace EduTots.Application.DTOs;

public class RegisterSchoolDto
{
    public int SchoolId { get; set; }

    public string? SchoolName { get; set; }

    public string? Address { get; set; }

    public string? PhoneNo { get; set; }

    public string? EmailAddress { get; set; }

    public string? Password { get; set; }

    public int? LocationId { get; set; }

    public string? ProprietorFullName { get; set; }

    public string? HeadFullName { get; set; }

    public string? DateAdded { get; set; }

    public string? DateLastUpdated { get; set; }

    public string? RegKey { get; set; }

    public string? Active { get; set; }

    public string? Uploaded { get; set; }
}