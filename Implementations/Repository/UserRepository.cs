using System.Collections.Generic;
using System.Linq;
using Cakes_N_Treats_By_Zannie.Context;
using Cakes_N_Treats_By_Zannie.Entities;
using Cakes_N_Treats_By_Zannie.Interfaces.IRepositories;
using Cakes_N_Treats_By_Zannie.Entities.Enums;
namespace Cakes_N_Treats_By_Zannie.Implementations.Repository
{
    public class UserRepository :IUserRepository
    {
        private readonly ZannieContext _context;
        public UserRepository(ZannieContext cont)
        {
            _context=cont;
        }
         public User Create(User Customer)
         {
             _context.Customers.Add(Customer);
             _context.SaveChanges();
             return Customer;
         }
        public User Update(User Customer)
        {
            _context.Customers.Update(Customer);
            _context.SaveChanges();
            return Customer;
        }
        public List<User> GetCustomers()
        {
           return _context.Customers.Where(L=>L.UserType== UserType.Customer).ToList();
        }
        public User GetCustomerById(int id)
        {
            return _context.Customers.Find(id);
        }
        public void Delete(User Customer)
        {
            _context.Customers.Remove(Customer);
            _context.SaveChanges();
        }

        public User GetCustomerByEmail(string Email)
        {
           var user= _context.Customers.SingleOrDefault(L=>L.EmailAddress==Email);
           return user;
        }
        public User GetCustomerByPassword(string Password)
        {
            var customer=_context.Customers.SingleOrDefault(L=>L.Password==Password);
            return customer;
        }
        public User GetDispatchRider(int id)
        {
            return _context.Customers.SingleOrDefault(userDel=> userDel.UserType==UserType.Dispatcher && userDel.Id==id);
        }
    }
}