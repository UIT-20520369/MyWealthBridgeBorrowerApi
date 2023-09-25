using Domain.AggregateModels.Borrowers;
using MyWealthBridgeBorrowerApi.DTOs.ExternalLogins;
using MyWealthBridgeBorrowerApi.DTOs.Users;

namespace MyWealthBridgeBorrowerApi.Services.BorrowerServices
{
    public interface IBorrowerService
    {
        Borrower Register(UserDTOcs userDTO);
        Borrower Login(UserDTOcs userDTO);
        public Borrower ExternalLogin(ExternalLoginInput input);
    }
}
