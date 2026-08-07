namespace EduTots.Domain.Entities;

public class EduTotsStaff
{
    public long EduTotsStaffId { get; set; }

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

    public string? Verified { get; set; }

    public string? ReferralPhoneNumber { get; set; }

    public virtual ICollection<EduTotsStaffBank> EduJuniorStaffBanks { get; set; } = new List<EduTotsStaffBank>();

    public virtual ICollection<PaymentRequest> PaymentRequests { get; set; } = new List<PaymentRequest>();

    public virtual ICollection<SchoolReferralAccount> SchoolReferralAccounts { get; set; } = new List<SchoolReferralAccount>();

    public virtual ICollection<SchoolReferral> SchoolReferrals { get; set; } = new List<SchoolReferral>();

    public virtual ICollection<StaffSchoolEngagement> StaffSchoolEngagements { get; set; } = new List<StaffSchoolEngagement>();
}