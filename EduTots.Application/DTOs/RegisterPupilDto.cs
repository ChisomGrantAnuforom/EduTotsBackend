namespace EduTots.Application.DTOs
{
    public class RegisterPupilDto
    {
        public long PupilId { get; set; }
        
        public string? FirstName { get; set; }

        public string? OtherNames { get; set; }

        public string? LastName { get; set; }

        public string? Sex { get; set; }

        public string? DateOfBirthDay { get; set; }

        public string? DateOfBirthMonth { get; set; }

        public string? DateOfBirthYear { get; set; }

        public string? HomeAddress { get; set; }

        public string? PhoneNumber { get; set; }

        public long? ParentId { get; set; }

        public int? ClassId { get; set; }

        public long? LevelId { get; set; }

        public int? SchoolId { get; set; }

    }
}
