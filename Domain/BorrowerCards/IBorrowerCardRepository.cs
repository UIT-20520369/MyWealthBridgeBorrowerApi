using Domain.SeedWord;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.BorrowerCards
{
    public interface IBorrowerCardRepository: IRepository<BorrowerCard>
    {
        public List<BorrowerCard> GetAllByUserId(int id);
        public BorrowerCard GetBorrowerCardById(int id);
        public BorrowerCard AddBorrowerCard(BorrowerCard card);
        public BorrowerCard UpdateBorrowerCard(BorrowerCard card);
        public void DeleteBorrowerCardById(int id);
    }
}
