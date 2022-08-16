using System.Collections.Generic;
using System.Linq;
using Cakes_N_Treats_By_Zannie.Entities;
using Cakes_N_Treats_By_Zannie.Interfaces.IRepositories;
using Cakes_N_Treats_By_Zannie.Interfaces.IServices;
using Cakes_N_Treats_By_Zannie.Models;

namespace Cakes_N_Treats_By_Zannie.Implementations.Services
{
    public class UserService :IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository= userRepository;
        }
         public bool CreateCustomer(CreateUserRequestModel model)
         {
             var cust= new User
             {
                Password=model.Password,
                FirstName= model.FirstName,
                LastName= model.LastName,
               EmailAddress= model.EmailAddress,
              UserAddress= model.CustomerAddress,
              PhoneNumber= model.PhoneNumber,
              UserPhoto= model.UserPhoto,
              UserType= Cakes_N_Treats_By_Zannie.Entities.Enums.UserType.Customer,
             };
             _userRepository.Create(cust);
             return true;
         }
          public bool CreateAdministrator(CreateUserRequestModel model)
         {
             var Administrator= new User
             {
                Password=model.Password,
                FirstName= model.FirstName,
                LastName= model.LastName,
               EmailAddress= model.EmailAddress,
              UserAddress= model.CustomerAddress,
              PhoneNumber= model.PhoneNumber,
              UserPhoto= model.UserPhoto,
              UserType=Cakes_N_Treats_By_Zannie.Entities.Enums.UserType.Administrator,
             };
             _userRepository.Create(Administrator);
             return true;
         }
        public bool Update(int id, UpdateUserRequestModel model)
        {
            var updatecustomer= _userRepository.GetCustomerById(id);
            if(updatecustomer==null)
            {
                throw new System.Exception("Customer Not Found");
            }
            updatecustomer.FirstName= model.FirstName;
            updatecustomer.LastName= model.LastName;
            updatecustomer.PhoneNumber= model.PhoneNumber;
            updatecustomer.UserAddress=model.Address;
             updatecustomer.Password=model.Password;
            _userRepository.Update(updatecustomer);
            return  true;
        }
        public IEnumerable<ViewUserRequestModel> GetCustomers()
        {
             return _userRepository.GetCustomers().Select(L=> new ViewUserRequestModel
             {
                 Id=L.Id,
                 CustomerAddress=L.UserAddress,
                 EmailAddress=L.EmailAddress,
                 FullName= $"{L.FirstName} {L.LastName}",
                 PhoneNumber=L.PhoneNumber,
                 UserPhoto=L.UserPhoto,
                UserType=L.UserType
             }
             ).ToList();
        }
       
        public ViewUserRequestModel GetCustomerById(int id)
        {
           var user= _userRepository.GetCustomerById(id);
           var usermodel= new ViewUserRequestModel
           {  Id= user.Id,
                CustomerAddress=user.UserAddress,
                 EmailAddress=user.EmailAddress,
                 FullName= $"{user.FirstName} {user.LastName}",
                 PhoneNumber=user.PhoneNumber,
                 UserPhoto=user.UserPhoto,
                 UserType=user.UserType,
                 Orders= user.Orders.Select(order=> new ViewOrderRequestModel
                   {
                     QuantityOfTreats=order.TotalOrderQuantityOnAChosenTreat,
                      OrderReference= order.OrderReference,
                      CustomerName=$"{user.FirstName} {user.LastName}",
                       CustomerAddress= user.UserAddress,
                      DeliveryDate= order.DeliveryDate,
                        OrderDate=order.DateOfOrder,
                       Id=order.Id,
                       CustomerId=user.Id,
                    }
                 ).ToList(),
           };
           return usermodel;
        }
        public void Delete(int id)
        {
            var delete= _userRepository.GetCustomerById(id);
            _userRepository.Delete(delete);
        }

        public ViewUserRequestModel Login(UserLoginRequestModel model)
        {
         var cust= _userRepository.GetCustomerByEmail(model.Email);
         if(cust==null|| model.Password!=cust.Password)
         {
             return null;
         }
         else
         {
             return new ViewUserRequestModel
             {
                Id= cust.Id,
                CustomerAddress=cust.UserAddress,
                 EmailAddress=cust.EmailAddress,
                 FullName= $"{cust.FirstName} {cust.LastName}",
                 PhoneNumber=cust.PhoneNumber,
                 UserPhoto=cust.UserPhoto,
                 UserType=cust.UserType
                 
             };
         }
        }
        public ViewUserRequestModel GetCustomerByPassword(string Password)
        {
            var cust= _userRepository.GetCustomerByPassword(Password);
            var user= new ViewUserRequestModel
             {
                 Id= cust.Id,
                CustomerAddress=cust.UserAddress,
                 EmailAddress=cust.EmailAddress,
                 FullName= $"{cust.FirstName} {cust.LastName}",
                 PhoneNumber=cust.PhoneNumber,
                 UserPhoto=cust.UserPhoto,
                 UserType=cust.UserType
                 
             };
             return user;
        }

        public bool CreateDispatcher(CreateUserRequestModel model)
        {
            var dispatcher= new User
            {
                FirstName=model.FirstName,
                LastName=model.LastName,
                EmailAddress=model.EmailAddress,
                Gender=model.Gender,
                Password=model.Password,
                PhoneNumber=model.PhoneNumber,
                UserAddress=model.CustomerAddress,
                UserType=Entities.Enums.UserType.Dispatcher,
                UserPhoto=model.UserPhoto,
            };
            _userRepository.Create(dispatcher);
            return true;
        }
          public IEnumerable<ViewUserRequestModel> GetDispatchers()
        {
             var users= _userRepository.GetCustomers().Where(L=> L.UserType == Entities.Enums.UserType.Dispatcher).Select(L=> new ViewUserRequestModel
             {
                 Id=L.Id,
                 CustomerAddress=L.UserAddress,
                 EmailAddress=L.EmailAddress,
                 FullName= $"{L.FirstName} {L.LastName}",
                 PhoneNumber=L.PhoneNumber,
                 UserPhoto=L.UserPhoto,
                UserType=L.UserType
             }
             ).ToList();
             return users;
        }
    }
}