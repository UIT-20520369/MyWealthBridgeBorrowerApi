using Domain.BorrowerCards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class BorrowerCardRepository : IBorrowerCardRepository
    {
        private CoreContext _coreContext;
        public BorrowerCardRepository(CoreContext coreContext)
        {
            _coreContext = coreContext;
        }

        public BorrowerCard AddBorrowerCard(BorrowerCard card)
        {
            var borrowerCardDoc = _coreContext.BorrowerCards.Where(bc => bc.Id == card.Id).FirstOrDefault();
            if (borrowerCardDoc != null)
            {
                return null;
            }
            else
            {
                _coreContext.BorrowerCards.Add(card);
                _coreContext.SaveChanges();
                return card;
            }    
        }

        public void DeleteBorrowerCardById(int id)
        {
            var borrowerCardDoc = _coreContext.BorrowerCards.Where(bc => bc.Id ==id).FirstOrDefault();
            if (borrowerCardDoc ==null)
            {
                throw new Exception("Card does not exist");
            }
            else
            {
                _coreContext.BorrowerCards.Remove(borrowerCardDoc);
                _coreContext.SaveChanges();
            }
        }

        public List<BorrowerCard> GetAllByUserId(int id)
        {
            return _coreContext.BorrowerCards.Where(bc => bc.BorrowerId == id).ToList();
        }

        public BorrowerCard GetBorrowerCardById(int id)
        {
            return _coreContext.BorrowerCards.Where(bc => bc.Id == id).FirstOrDefault();
        }

        public BorrowerCard UpdateBorrowerCard(BorrowerCard card)
        {
            var borrowerCardDoc = _coreContext.BorrowerCards.Where(bc => bc.Id == card.Id).FirstOrDefault();
            if (borrowerCardDoc == null)
            {
                return null;
            }
            else
            {
                borrowerCardDoc.Update(card);
                _coreContext.SaveChanges();
                return borrowerCardDoc;
            }
        }
    }
}
