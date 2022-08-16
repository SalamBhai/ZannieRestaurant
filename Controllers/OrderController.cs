using System;
using System.Linq;
using Cakes_N_Treats_By_Zannie.Interfaces.IServices;
using Cakes_N_Treats_By_Zannie.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Security.Claims;
using System.Collections.Generic;
namespace Cakes_N_Treats_By_Zannie.Controllers
{
    public class OrderController :Controller
    {
        private readonly IOrderService _orderService;
        private readonly IUserService _userService;
        private readonly ITreatService _treatService;
        public OrderController(IOrderService orderservice,ITreatService treat, IUserService userservice)
        {
            _orderService=orderservice;
            _treatService=treat;
            _userService=userservice;
        }
        public IActionResult Index()
        {
            return View("Create");
        }
        [Authorize(Roles="Customer")]
        public IActionResult Create()
        {
            var treats= _treatService.GetTreats();
            ViewData["Treats"]= new SelectList(treats,"id","Name");
            return View();
        }
        
        [HttpPost]
        public IActionResult Create(CreateOrderRequestModel model,int customer)
        {
            customer= int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
            _orderService.Create(model,customer);
            return RedirectToAction("Created");
        }
        public IActionResult Created()
        {
            return View();
        }
         public IActionResult GetDeliveredOrders()
         {
             var deliveredOrders= _orderService.GetDeliveredOrders();
             return View(deliveredOrders);
         }   
         public IActionResult GetNewOrders()
         {
             var newOrders=_orderService.GetNewOrders();
             return View(newOrders);
         }

        public IActionResult GetOrder(int id)
        {
            var order= _orderService.GetOrder(id);
            return View(order);
        }
        public IActionResult GetAUserOrder(int id)
        {
            int userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
            var order= _orderService.GetOrder(userId,id);
            return View(order);
        }
        [Authorize(Roles="Administrator")]
        public IActionResult UpdateOrderByAdmin(int id)
        {
            var theOrder =_orderService.GetOrder(id);
           if(theOrder==null)
           {
               return NotFound();
           }
           return View();
 
        }
     
        [HttpPost]
        public IActionResult UpdateOrderByAdmin(int id, AdminUpdateOrderRequestModel model)
        {
            var order=_orderService.GetOrder(id);
            int customerId= order.CustomerId;
            _orderService.Update(id,model,customerId);
            return RedirectToAction("FindOrders");
        }

        // [Authorize(Roles="Customer")]
        //  public IActionResult UpdateOrderByCustomer(int id)
        // {
        //     int customerId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
        //    var theorder =_orderService.GetOrder(id, customerId);
        //    if(theorder==null)
        //    {
        //        return NotFound();
        //    }
        //    return View();
 
        // }

        // [HttpPost]
        // public IActionResult UpdateOrderByCustomer(int id, UserUpdateOrderRequestModel model)
        // {
        //     int userid= int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
        //     _orderService.Update(id,model,userid);
        //     return RedirectToAction("GetAUserOrder");
        // }
        public IActionResult GetMyOrders()
        {
            int id= int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
            var order= _orderService.FindMyOrders(id);
            if(order==null)
            {
                return NotFound();
            }
            return View(order);
        }
        public IActionResult FindOrders()
        {
           var orders= _orderService.GetOrders();
           return View(orders);
        }                          
        public IActionResult GetOrdersByDate(DateTime orderdate)
        {
            var orders=_orderService.GetOrders();
            return View(orders);
        }
          [Authorize(Roles="Administrator")]
        public IActionResult Delete(int id)
        {
           var ordertodelete= _orderService.GetOrder(id);
           return View(ordertodelete);
        }
        
        [HttpPost,ActionName("Delete")]
        public IActionResult DeleteMade(int id)
        {
           _orderService.Delete(id);
           return RedirectToAction("GetOrders");
        }      
    }
}