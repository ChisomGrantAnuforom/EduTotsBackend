namespace EduTots.Domain.Entities;

public class PaymentRequest
{
    public long PaymentRequestId { get; set; }

    public long? SomicleStaffId { get; set; }

    public decimal? AmountToPay { get; set; }

    public string? Settled { get; set; }

    public string? DateOfRequest { get; set; }

    public string? DateOfSettlement { get; set; }

    public virtual EduTotsStaff? SomicleStaff { get; set; }
}