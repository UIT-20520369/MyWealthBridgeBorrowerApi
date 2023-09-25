using Domain.AggregateModels.Borrowers;
using Domain.AggregateModels.ExternalLogins;
using Infrastructure.Repositories;
using MyWealthBridgeBorrowerApi.DTOs.ExternalLogins;
using MyWealthBridgeBorrowerApi.DTOs.Users;

namespace MyWealthBridgeBorrowerApi.Services.BorrowerServices
{
    public class BorrowerService : IBorrowerService
    {
        private readonly IBorrowerRepository borrowerRepository;
        private readonly IExternalLoginRepository externalLoginRepository;
        public BorrowerService(IBorrowerRepository repository, IExternalLoginRepository externalLoginRepository)
        {
            this.borrowerRepository = repository;
            this.externalLoginRepository = externalLoginRepository;
        }
        public Borrower ExternalLogin(ExternalLoginInput input)
        {
            var userDoc = borrowerRepository.FindBorrowerByEmail(input.Email);
            if (userDoc == null)
            {
                var newUser = new Borrower();
                newUser.Email = input.Email;
                newUser.Name = input.Name;
                var addedUser = borrowerRepository.AddBorrower(newUser);
                var newExternalLogin = new ExternalLogin(addedUser.Id,input.providerName,input.providerId);
                externalLoginRepository.AddExternalLogin(newExternalLogin);
                return addedUser;
            }
            else
            {
                var newExternalLogin = new ExternalLogin(userDoc.Id, input.providerName, input.providerId);
                return userDoc;
            }    
        }
        public Borrower Login(UserDTOcs userDto)
        {
            var userDoc = borrowerRepository.CheckExistedUser(userDto.Email);
            if (userDoc == null)
            {
                return null;
            }
            bool isPasswordValid = BCrypt.Net.BCrypt.Verify(userDto.Password, userDoc.Password);
            if (isPasswordValid)
            {
                return userDoc;
            }
            else return null;
        }


        public Borrower Register(UserDTOcs userDto)
        {
            var userDoc = borrowerRepository.CheckExistedUser(userDto.Email);
            if (userDoc != null)
            {
                return null;
            }
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(userDto.Password);
            var user = new Borrower(userDto.Name, userDto.Email, hashedPassword, userDto.Phone);
            borrowerRepository.AddBorrower(user);
            return user;
        }

    }
}
