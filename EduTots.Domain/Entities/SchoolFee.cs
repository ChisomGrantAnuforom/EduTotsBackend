namespace EduTots.Domain.Entities;

public class SchoolFee
{
    public long SchoolFeeId { get; set; }

    public long? SchoolFeeIdLocal { get; set; }

    public long? SessionId { get; set; }

    public long? TermId { get; set; }

    public string? TermStartDateDay { get; set; }

    public string? TermStartDateMonth { get; set; }

    public string? TermStartDateYear { get; set; }

    public decimal? AmountToPay { get; set; }

    public decimal? AmountToSomicle { get; set; }

    public decimal? TotalAmountToPay { get; set; }

    public decimal? AmountPaid { get; set; }

    public decimal? Balance { get; set; }

    public long? PupilId { get; set; }

    public int? AssignedSms { get; set; }

    public int? SchoolId { get; set; }

    public string? Uploaded { get; set; }

    public string? Remitted { get; set; }

    public int? DateDay { get; set; }

    public int? DateMonth { get; set; }

    public int? DateYear { get; set; }

    public string? DateFinal { get; set; }

    
}