using System.Collections.Generic;
using Cakes_N_Treats_By_Zannie.Models;
using Cakes_N_Treats_By_Zannie.Entities;
namespace Cakes_N_Treats_By_Zannie.Interfaces.IServices
{
    public interface IUserService
    {
         public bool CreateCustomer(CreateUserRequestModel model);
        public bool Update(int id, UpdateUserRequestModel model);
        public IEnumerable<ViewUserRequestModel> GetCustomers();
        public ViewUserRequestModel GetCustomerById(int id);
        public void Delete(int id);
        public ViewUserRequestModel Login(UserLoginRequestModel model);
        public  ViewUserRequestModel GetCustomerByPassword(string Password);
         public bool CreateAdministrator(CreateUserRequestModel model);
          public bool CreateDispatcher(CreateUserRequestModel model);
           public IEnumerable<ViewUserRequestModel> GetDispatchers();
    }
}