namespace EduTots.Domain.Entities;

public class EduTotsStaffBank
{
    public long EduTotsStaffBankId { get; set; }

    public string? BankName { get; set; }

    public string? AccountName { get; set; }

    public string? AccountNo { get; set; }

    public string? SortCode { get; set; }

    public string? DateAdded { get; set; }

    public string? DateLastUpdated { get; set; }

    public long? EduJuniorStaffId { get; set; }

    public virtual EduTotsStaff? EduJuniorStaff { get; set; }
}