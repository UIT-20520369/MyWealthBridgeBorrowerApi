using Domain.BorrowerCards;
using MyWealthBridgeBorrowerApi.DTOs.BorrowerCards;

namespace MyWealthBridgeBorrowerApi.Services.BorrowerCardServices
{
    public class BorrowerCardService : IBorrowerCardService
    {
        private readonly IBorrowerCardRepository repository;
        public BorrowerCardService(IBorrowerCardRepository repository)
        {
            this.repository = repository;
        }

        public BorrowerCard AddBorrowerCard(BorrowerCardDTO card)
        {
            var newCard = new BorrowerCard(card.BorrowerId.Value,card.Issuer,card.AuthorizedUser,card.Limit.Value,card.Balance.Value,card.DateDue,card.DateReporting,card.RecurringCharges,card.DateCreated,card.DateModified,card.ModifiedBy);
            return repository.AddBorrowerCard(newCard);
        }

        public void DeleteBorrowerCardById(int id)
        {
            repository.DeleteBorrowerCardById(id);
        }

        public List<BorrowerCard> GetAllByUserId(int id)
        {
            return repository.GetAllByUserId(id);
        }
        public BorrowerCard GetBorrowerCardById(int id)
        {
            return repository.GetBorrowerCardById(id) ;
        }
        public BorrowerCard UpdateBorrowerCard(BorrowerCardDTO card)
        {
            var newCard = new BorrowerCard(card.Id.Value,card.BorrowerId.Value, card.Issuer, card.AuthorizedUser, card.Limit.Value, card.Balance.Value, card.DateDue, card.DateReporting, card.RecurringCharges, card.DateCreated, card.DateModified, card.ModifiedBy);
            return repository.UpdateBorrowerCard(newCard);
        }
    }
}
