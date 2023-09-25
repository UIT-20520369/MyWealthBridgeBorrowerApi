using Domain.AggregateModels.ExternalLogins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class ExternalRepository : IExternalLoginRepository
    {
        private CoreContext _coreContext;
        public ExternalRepository(CoreContext coreContext)
        {
            _coreContext = coreContext;
        }

        public ExternalLogin AddExternalLogin(ExternalLogin externalLogin)
        {
            _coreContext.ExternalLogins.Add(externalLogin);
            _coreContext.SaveChanges();
            return externalLogin;
        }

        public ExternalLogin GetExternalLoginByUserId(int userId, string provider)
        {
            return _coreContext.ExternalLogins.Where(e => e.UserId == userId && e.LoginProvider==provider).FirstOrDefault();
        }
    }
}
