using System;
using System.Collections.Generic;
using System.Linq;
using Cakes_N_Treats_By_Zannie.Entities;
using Cakes_N_Treats_By_Zannie.Interfaces.IServices;
using Cakes_N_Treats_By_Zannie.Models;
using user.Desktop.Cakes_N_Treats_By_Zannie.Entities;
using Cakes_N_Treats_By_Zannie.Interfaces.IRepositories;
using Cakes_N_Treats_By_Zannie.Enums;
namespace Cakes_N_Treats_By_Zannie.Implementations.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepo;
        private readonly ITreatRepository Treatrepository;
         private readonly    ITreatOrderRepository _treatOrderRepository;
        public OrderService(IOrderRepository orderRepo, ITreatRepository treatrepository,  ITreatOrderRepository treatOrderRepository)
        {
            _orderRepo = orderRepo;
            Treatrepository = treatrepository;
              _treatOrderRepository= treatOrderRepository;
        }
       
        
        public bool Create(CreateOrderRequestModel order,int customerid)
        {
           var cart= order.Treats.Where(itemPicked=>itemPicked.Quantity > 0).ToDictionary(itemPicked => itemPicked.TreatId, itemPicked=> itemPicked.Quantity);
             var cartItems = Treatrepository.Query().Where(treatSelected => cart.Keys.Contains(treatSelected.Id)).ToList();
            var deliciousinterest = new Order
            {
                DateOfOrder = DateTime.Now,
                DeliveryDate = order.DeliveryDate,
                OrderReference = $"{DateTime.Now.ToShortDateString()}/{Guid.NewGuid().ToString().Substring(1, 12).Replace('-', '/')}",
                UserId = customerid,
                OrderStatus=Enums.OrderStatus.New,
                DeliveryAddress= order.DeliveryAddress,
                //PaymentPaid= false,
            };
           
            foreach (var treat in cartItems)
            {
              var quantity= cart[treat.Id];
              var price= treat.TreatPrice;
                var treatOrder= new TreatOrders
                {
                    Order = deliciousinterest,
                    OrderID = deliciousinterest.Id,
                    Treat = treat,
                    TreatId = treat.Id,
                   UnitQuantity= quantity,
                    UnitPrice = price,
                };
                deliciousinterest.OrderPrice += (order.NumberOfQuantities*treat.TreatPrice);
                deliciousinterest.TotalOrderQuantityOnAChosenTreat= _treatOrderRepository.GetTreatsCountByOrderID(deliciousinterest.Id);
                deliciousinterest.TreatOrders.Add(treatOrder);
            }
           _orderRepo.Create(deliciousinterest);
            return true;
        }

       

        public bool Delete(int id)
        {
            var orderDelete = _orderRepo.GetOrder(id);
            _orderRepo.DeleteOrder(orderDelete);
            return true;
        }

        public IEnumerable<ViewOrderRequestModel> FindMyOrders(int id)
        {
            var orders = _orderRepo.GetMyOrders(id).Select(orderModel=> new ViewOrderRequestModel
            {
                Id=orderModel.Id,
                DeliveryDate = orderModel.DeliveryDate,
                OrderDate = orderModel.DateOfOrder,
                OrderPrice = orderModel.OrderPrice,
                OrderReference = orderModel.OrderReference,
                 QuantityOfTreats = orderModel.TotalOrderQuantityOnAChosenTreat,
                 OrderStatus=orderModel.OrderStatus,
                TreatsContainedInOrder= _treatOrderRepository.GetTreatsCountByOrderID(orderModel.Id),
                Treats = _treatOrderRepository.GetTreatsByOrderID(orderModel.Id).Select(treatOrder => new ViewTreatRequestModel
                {
                    Name = treatOrder.Treat.Name,
                    TreatPrice = treatOrder.Treat.TreatPrice,
                    id = treatOrder.Treat.Id,
                }).ToList(),
            }).ToList();
            return orders;
        }
        
        
        public IEnumerable<ViewOrderRequestModel> GetOrders()
        {
            return _orderRepo.GetOrders().Select(order => new ViewOrderRequestModel
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
        
        public bool Update(int id, AdminUpdateOrderRequestModel model,int userid)
         {
            var getorder = _orderRepo.GetOrder(id,userid);
            getorder.OrderStatus= model.OrderStatus;
            if (model.OrderStatus==OrderStatus.Paid) {getorder.PaymentPaid=true;}
            _orderRepo.Update(getorder);
            return true;
         }
         //  public bool Update(int id, UserUpdateOrderRequestModel model,int userid)
        // {
        //     var getorder = _orderRepo.GetOrder(id,userid);
        //     get.OrderStatus==model.
        //     if (true)
        //     {
              
        //     }
        //     _orderRepo.Update(getorder);
        //     return true;
        // }
        public ViewOrderRequestModel GetOrder(int id)
        {
          var order= _orderRepo.GetOrder(id);
          var Order= new ViewOrderRequestModel
           {
                Id=order.Id,
                CustomerId=order.UserId,
                CustomerAddress = order.User.UserAddress,
                CustomerName = order.User.FirstName,
                DeliveryDate = order.DeliveryDate,
                OrderDate = order.DateOfOrder,
                OrderPrice = order.OrderPrice,
                OrderReference = order.OrderReference,
                 QuantityOfTreats  = order.TotalOrderQuantityOnAChosenTreat,
                 OrderStatus=order.OrderStatus,
                TreatsContainedInOrder = _treatOrderRepository.GetTreatsCountByOrderID(order.Id),
               Treats = _treatOrderRepository.GetTreatsByOrderID(order.Id).Select(treatOrder => new ViewTreatRequestModel
                {
                    Name = treatOrder.Treat.Name,
                    TreatPrice = treatOrder.Treat.TreatPrice,
                    id = treatOrder.Treat.Id,
                }).ToList(),           
            };
            return Order;
        }

         public ViewOrderRequestModel GetOrder(int id,int userid)
        {
          var order= _orderRepo.GetOrder(id,userid);
          var returningOrder= new ViewOrderRequestModel
          {
                Id=order.Id,
                CustomerId=order.UserId,
                CustomerAddress = order.User.UserAddress,
                CustomerName = order.User.FirstName,
                DeliveryDate = order.DeliveryDate,
                OrderDate = order.DateOfOrder,
                OrderPrice = order.OrderPrice,
                OrderReference = order.OrderReference,
                 QuantityOfTreats  = order.TotalOrderQuantityOnAChosenTreat,
                TreatsContainedInOrder = _treatOrderRepository.GetTreatsCountByOrderID(order.Id),
                OrderStatus=order.OrderStatus,
                 Treats = _treatOrderRepository.GetTreatsByOrderID(order.Id).Select(treatOrder => new ViewTreatRequestModel
                   {
                      Name = treatOrder.Treat.Name,
                      TreatPrice = treatOrder.Treat.TreatPrice,
                      id = treatOrder.Treat.Id,
                  }).ToList(),           
            };
            return returningOrder;
        }
       public IEnumerable<ViewOrderRequestModel> GetDeliveredOrders()
       {
            return _orderRepo.GetOrders().Where(Order=> Order.OrderStatus== Enums.OrderStatus.Delivered).Select(order => new ViewOrderRequestModel
            {
                 Id=order.Id,
                 CustomerId= order.UserId,
                 CustomerAddress = order.User.UserAddress,
                 CustomerName = $"{order.User.FirstName} {order.User.LastName}",
                 DeliveryDate = order.DeliveryDate,
                 OrderDate = order.DateOfOrder,
                 OrderPrice = order.OrderPrice,
                   QuantityOfTreats =  order.TotalOrderQuantityOnAChosenTreat,
                  OrderStatus=order.OrderStatus,
                 OrderReference = order.OrderReference,
                 TreatsContainedInOrder = _treatOrderRepository.GetTreatsCountByOrderID(order.Id),
                  Treats = _treatOrderRepository.GetTreatsByOrderID(order.Id).Select(treatOrder => new ViewTreatRequestModel
                 {
                   Name = treatOrder.Treat.Name,
                     TreatPrice = treatOrder.Treat.TreatPrice,
                   id = treatOrder.Treat.Id,
                 }).ToList(),
            }).ToList();
       }
       public IEnumerable<ViewOrderRequestModel> GetNewOrders()
       {
           return _orderRepo.GetOrders().Where(Order=>Order.OrderStatus==Enums.OrderStatus.New).Select(newOrder=> new ViewOrderRequestModel
             {
                  Id=newOrder.Id,
                 CustomerId= newOrder.UserId,
                 CustomerAddress = newOrder.User.UserAddress,
                 CustomerName = $"{newOrder.User.FirstName} {newOrder.User.LastName}",
                 DeliveryDate = newOrder.DeliveryDate,
                 OrderDate = newOrder.DateOfOrder,
                 OrderPrice = newOrder.OrderPrice,
                   QuantityOfTreats =  newOrder.TotalOrderQuantityOnAChosenTreat,
                  OrderReference = newOrder.OrderReference,
                 TreatsContainedInOrder = _treatOrderRepository.GetTreatsCountByOrderID(newOrder.Id),
                  Treats = _treatOrderRepository.GetTreatsByOrderID(newOrder.Id).Select(treatOrder => new ViewTreatRequestModel
                 {
                   Name = treatOrder.Treat.Name,
                     TreatPrice = treatOrder.Treat.TreatPrice,
                   id = treatOrder.Treat.Id,
                 }).ToList(),
             }).ToList();
        }
       public IEnumerable<ViewOrderRequestModel> SearchOrderByDate(DateTime Date)
       {
         return _orderRepo.SearchOrder(Date.ToString()).ToList();
       }
    }

}