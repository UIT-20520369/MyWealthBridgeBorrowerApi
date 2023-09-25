using Domain.AggregateModels.Borrowers;

namespace MyWealthBridgeBorrowerApi.DTOs.BorrowerCards
{
    public class BorrowerCardDTO
    {
        public int? Id { get; set; }
        public int? BorrowerId { get; set; }
        public string? Issuer { get; set; }
        public bool? AuthorizedUser { get; set; }
        public double? Limit { get; set; }
        public double? Balance { get; set; }
        public DateTime? DateDue { get; set; }
        public DateTime? DateReporting { get; set; }
        public double? RecurringCharges { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public string? ModifiedBy { get; set; }
        public BorrowerCardDTO(int? id, int? borrowerId, string? issuer, bool? authorizedUser, double? limit, double? balance, DateTime? dateDue, DateTime? dateReporting, double? recurringCharges, DateTime? dateCreated, DateTime? dateModified, string? modifiedBy)
        {
            Id = id;
            BorrowerId = borrowerId;
            Issuer = issuer;
            AuthorizedUser = authorizedUser;
            Limit = limit;
            Balance = balance;
            DateDue = dateDue;
            DateReporting = dateReporting;
            RecurringCharges = recurringCharges;
            DateCreated = dateCreated;
            DateModified = dateModified;
            ModifiedBy = modifiedBy;
        }
        public BorrowerCardDTO() { }
    }
}
