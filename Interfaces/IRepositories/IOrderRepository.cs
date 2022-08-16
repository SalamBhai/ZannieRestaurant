using System.Collections.Generic;
using Cakes_N_Treats_By_Zannie.Entities;
using Cakes_N_Treats_By_Zannie.Models;

namespace Cakes_N_Treats_By_Zannie.Interfaces.IRepositories
{
    public interface IOrderRepository
    {
        public Order Create(Order order);
        public IEnumerable<Order> GetMyOrders(int userid);
        public Order GetOrder(int id);
        public Order Update(Order order);
        public void DeleteOrder(Order order);
        public IEnumerable<Order> GetOrders();
        public Order GetOrder(int id,int userid);
        public IEnumerable<Order> GetDeliveredOrders();
        public IEnumerable<ViewOrderRequestModel> SearchOrder(string searchText);
    }
}