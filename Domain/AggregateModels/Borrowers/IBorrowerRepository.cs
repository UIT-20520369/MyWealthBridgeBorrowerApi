using Domain.AggregateModels.Borrowers;
using Domain.SeedWord;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.AggregateModels.Borrowers
{
    public interface IBorrowerRepository : IRepository<Borrower>
    {
        List<Borrower> GetAll();
        Borrower CheckExistedUser(string mail);
        Borrower AddBorrower(Borrower borrower);
        public Borrower FindBorrowerByEmail(string email);
        public Borrower GetBorrowerById(int id);
    }
}
