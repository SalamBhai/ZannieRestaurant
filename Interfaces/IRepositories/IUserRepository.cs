using System.Collections.Generic;
using Cakes_N_Treats_By_Zannie.Entities;

namespace Cakes_N_Treats_By_Zannie.Interfaces.IRepositories
{
    public interface IUserRepository
    {
        public User Create(User Customer);
        public User Update(User Customer);
        public List<User> GetCustomers();
        public User GetCustomerById(int id);
        public void Delete(User Customer);
        public User GetCustomerByEmail(string Email);
        public User GetCustomerByPassword(string Password);
    }
}