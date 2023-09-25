using Domain.AggregateModels.Borrowers;
using Domain.SeedWord;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Domain.BorrowerCards
{
    public  class BorrowerCard: IAggregateRoot
    {
        public int Id { get; set; }
        public int BorrowerId { get; set; }
        public string Issuer { get; set; }
        public bool? AuthorizedUser { get; set; }
        public double Limit { get; set; }
        public double Balance { get; set; }
        public DateTime? DateDue { get; set; }
        public DateTime? DateReporting { get; set; }
        public double? RecurringCharges { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public string? ModifiedBy { get; set; }
        public Borrower Borrower { get; set; }
        public BorrowerCard() {

            DateCreated = DateTime.Now;
        }
        public BorrowerCard(int id, int borrowerId, string issuer, bool? authorizedUser, double limit, double balance, DateTime? dateDue, DateTime? dateReporting, double? recurringCharges, DateTime? dateCreated, DateTime? dateModified, string? modifiedBy)
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
            DateCreated = dateCreated != null ? dateCreated : DateTime.Now;
            DateModified = dateCreated;
            ModifiedBy = modifiedBy;
        }
        public BorrowerCard(int borrowerId, string issuer, bool? authorizedUser, double limit, double balance, DateTime? dateDue, DateTime? dateReporting, double? recurringCharges, DateTime? dateCreated, DateTime? dateModified, string? modifiedBy)
        {
            BorrowerId = borrowerId;
            Issuer = issuer;
            AuthorizedUser = authorizedUser;
            Limit = limit;
            Balance = balance;
            DateDue = dateDue;
            DateReporting = dateReporting;
            RecurringCharges = recurringCharges;
            DateCreated = dateCreated != null ? dateCreated : DateTime.Now;
            DateModified = dateCreated;
            ModifiedBy = modifiedBy;
        }
        public void Update(BorrowerCard card)
        {
            foreach (var item in card.GetType().GetProperties())
            {
                if (item.Name == "Id") continue;
                //if (item.PropertyType == typeof(int) && item.GetValue(group).ToString() == "0") continue;
                //if (item.PropertyType == typeof(double) && item.GetValue(group).ToString() == "0") continue;
                if (item.GetValue(card) == null) continue;
                this.GetType().GetProperty(item.Name).SetValue(this, item.GetValue(card));
            }
        }
    }
}
