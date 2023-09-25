using Domain.SeedWord;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.AggregateModels.ExternalLogins
{
    public interface IExternalLoginRepository: IRepository<ExternalLogin>
    {
        ExternalLogin GetExternalLoginByUserId(int  userId,string provider);
        ExternalLogin AddExternalLogin(ExternalLogin externalLogin);
    }
}
