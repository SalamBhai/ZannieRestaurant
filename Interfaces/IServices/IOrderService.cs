using System.Collections.Generic;
using Cakes_N_Treats_By_Zannie.Models;
using Cakes_N_Treats_By_Zannie.Entities;
using System;
namespace Cakes_N_Treats_By_Zannie.Interfaces.IServices
{
    public interface IOrderService
    {
        public bool Create(CreateOrderRequestModel order,int customerid);
        public IEnumerable<ViewOrderRequestModel> FindMyOrders(int id);
        public IEnumerable<ViewOrderRequestModel> GetOrders();
        public bool Update(int id, AdminUpdateOrderRequestModel model,int userid);
       // public bool Update(int id, UserUpdateOrderRequestModel model,int userid);
        public bool Delete(int id);
        public ViewOrderRequestModel GetOrder(int id);
        public ViewOrderRequestModel GetOrder(int id,int userid);
        public IEnumerable<ViewOrderRequestModel> GetDeliveredOrders();
        public IEnumerable<ViewOrderRequestModel> GetNewOrders();
        public IEnumerable<ViewOrderRequestModel> SearchOrderByDate(DateTime dateofOrder);
        
    }
}