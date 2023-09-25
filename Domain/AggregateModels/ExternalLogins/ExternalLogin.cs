using Domain.AggregateModels.Borrowers;
using Domain.SeedWord;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.AggregateModels.ExternalLogins
{
    public class ExternalLogin: IAggregateRoot
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string LoginProvider { get; set; }
        public string ProviderKey { get; set; }

        public string? ReturnUrl { get; set; }
        public Borrower User { get; set; }

        public ExternalLogin(int id, int userId, string loginProvider, string providerKey, string returnUrl ="")
        {
            Id = id;
            UserId = userId;
            LoginProvider = loginProvider;
            ProviderKey = providerKey;
            ReturnUrl = returnUrl;
        }
        public ExternalLogin( int userId, string loginProvider, string providerKey, string returnUrl="")
        {
            UserId = userId;
            LoginProvider = loginProvider;
            ProviderKey = providerKey;
            ReturnUrl = returnUrl;
        }
        public ExternalLogin() { }
    }
}
