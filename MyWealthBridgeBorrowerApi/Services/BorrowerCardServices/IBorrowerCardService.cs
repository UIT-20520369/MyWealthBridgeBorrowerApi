using Domain.BorrowerCards;
using MyWealthBridgeBorrowerApi.DTOs.BorrowerCards;

namespace MyWealthBridgeBorrowerApi.Services.BorrowerCardServices
{
    public interface IBorrowerCardService
    {
        public List<BorrowerCard> GetAllByUserId(int id);
        public BorrowerCard GetBorrowerCardById(int id);
        public BorrowerCard AddBorrowerCard(BorrowerCardDTO card);
        public BorrowerCard UpdateBorrowerCard(BorrowerCardDTO card);
        public void DeleteBorrowerCardById(int id);
    }
}
