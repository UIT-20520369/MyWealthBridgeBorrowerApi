using Domain.AggregateModels.ExternalLogins;
using Domain.BorrowerCards;
using Domain.SeedWord;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.AggregateModels.Borrowers
{
    public class Borrower: IAggregateRoot
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string? Password { get; set; }
        public string? Phone { get; set; }
        public ExternalLogin? ExternalLogin { get; set; }
        public ICollection<BorrowerCard> BorrowerCards { get; set; }
        public Borrower(int id, string name, string email, string password, string phone)
        {
            Id = id;
            Name = name;
            Email = email;
            Password = password;
            Phone = phone;
        }
        public Borrower( string name, string email, string password, string phone)
        {
            Name = name;
            Email = email;
            Password = password;
            Phone = phone;
        }
        public Borrower() { }
    }
}
