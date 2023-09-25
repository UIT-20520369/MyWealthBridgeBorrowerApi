using Domain.AggregateModels.Borrowers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class BorrowerRepository : IBorrowerRepository
    {
        private CoreContext _coreContext { get; set; }
        public BorrowerRepository(CoreContext coreContext)
        {
            _coreContext = coreContext;
        }

        public List<Borrower> GetAll()
        {
            return _coreContext.Borrowers.ToList();
        }
        public Borrower CheckExistedUser(string mail)
        {
            return _coreContext.Borrowers.Where(x => x.Email ==mail).FirstOrDefault();
        }
        public Borrower AddBorrower(Borrower borrower)
        {
            _coreContext.Borrowers.Add(borrower);
            _coreContext.SaveChanges();
            return borrower;
        }

        public Borrower FindBorrowerByEmail(string email)
        {
            return _coreContext.Borrowers.Where(b => b.Email == email).FirstOrDefault();
        }

        public Borrower GetBorrowerById(int id)
        {
            return _coreContext.Borrowers.Where(b => b.Id == id).Include(b => b.BorrowerCards).FirstOrDefault();
        }
    }
}
