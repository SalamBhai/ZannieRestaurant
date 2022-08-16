using System.Collections.Generic;
using System.Linq;
using Cakes_N_Treats_By_Zannie.Context;
using Cakes_N_Treats_By_Zannie.Entities;
using Cakes_N_Treats_By_Zannie.Enums;
using Cakes_N_Treats_By_Zannie.Interfaces.IRepositories;
using Microsoft.EntityFrameworkCore;
using Cakes_N_Treats_By_Zannie.Models;
namespace Cakes_N_Treats_By_Zannie.Implementations.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly ZannieContext _zannie;
        private readonly ITreatOrderRepository _treatOrderRepository;
        public OrderRepository(ZannieContext zannie,ITreatOrderRepository treatOrderRepository)
        {
            _zannie=zannie;
            _treatOrderRepository = treatOrderRepository;
        }
        public Order Create(Order order)
        {
           _zannie.Orders.Add(order);
           _zannie.SaveChanges();
           return order;
        }
        public IEnumerable<Order> GetMyOrders(int id)
         {
           var zannieorder=  _zannie.Orders.Include(L=> L.TreatOrders).ThenInclude(L=>L.Treat).Where(L=>L.UserId==id).ToList();
           return zannieorder;
         }
        public IEnumerable<Order> GetOrders()
        {
            return _zannie.Orders.Include(u=> u.User).ToList();
        }
        public Order Update(Order order)
        {
             _zannie.Orders.Update(order);
             _zannie.SaveChanges();
             return order;
        }
        public void DeleteOrder(Order order)
        {
            _zannie.Orders.Remove(order);
            _zannie.SaveChanges();
        }
       
        public Order GetOrder(int id)
        {
            return _zannie.Orders.Include(L=> L.TreatOrders).ThenInclude(L=> L.Treat).Include(S=> S.User).SingleOrDefault(D=> D.Id==id);
        }
         public Order GetOrder(int id,int userid)
        {
            return _zannie.Orders.Include(L=> L.TreatOrders).ThenInclude(L=> L.Treat).Include(S=> S.User).SingleOrDefault(D=> D.Id==id && D.UserId==userid);
        }
        public IEnumerable<Order> GetDeliveredOrders()
        {
            return _zannie.Orders.Include(L=> L.TreatOrders).ThenInclude(L=> L.Treat).Include(S=> S.User).Where(P=> P.OrderStatus==Enums.OrderStatus.Delivered).ToList();
        }
        public IEnumerable<ViewOrderRequestModel> SearchOrder(string searchText)
        {
            return _zannie.Orders.Where(order=> EF.Functions.Like(order.OrderReference, $"%{searchText}%")).Select(order => new ViewOrderRequestModel
            {
                 Id=order.Id,
                 CustomerId= order.UserId,
                 CustomerAddress = order.User.UserAddress,
                 CustomerName = $"{order.User.FirstName} {order.User.LastName}",
                 DeliveryDate = order.DeliveryDate,
                 OrderDate = order.DateOfOrder,
                 OrderPrice = order.OrderPrice,
                   QuantityOfTreats =  order.TotalOrderQuantityOnAChosenTreat,
                 OrderReference = order.OrderReference,
                  OrderStatus=order.OrderStatus,
                 TreatsContainedInOrder = _treatOrderRepository.GetTreatsCountByOrderID(order.Id),
                 DeliveryAddress=order.DeliveryAddress,
                  Treats = _treatOrderRepository.GetTreatsByOrderID(order.Id).Select(treatOrder => new ViewTreatRequestModel
                    {
                     Name = treatOrder.Treat.Name,
                     TreatPrice = treatOrder.Treat.TreatPrice,
                     id = treatOrder.Treat.Id,
                 }).ToList(),
            }).ToList();
        }
    }
}