namespace EduTots.Application.DTOs;

public class RegisterParentDto
{
    public long ParentId { get; set; }

    public long? ParentIdLocal { get; set; }

    public string? Title { get; set; }

    public string? FirstName { get; set; }

    public string? OtherNames { get; set; }

    public string? LastName { get; set; }

    public string? Sex { get; set; }

    public string? HomeAddress { get; set; }

    public string? PhoneNumber { get; set; }

    public string? EmailAddress { get; set; }

    public string? Password { get; set; }

    public string? DateRegistered { get; set; }

    public string? DateLastUpdated { get; set; }

    public string? Uploaded { get; set; }

    public string? Occupation { get; set; }
}