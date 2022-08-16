using Cakes_N_Treats_By_Zannie.Interfaces.IServices;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Cakes_N_Treats_By_Zannie.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Security.Claims;
using System.Collections.Generic;
using Cakes_N_Treats_By_Zannie.Enums;
namespace Cakes_N_Treats_By_Zannie.Controllers
{
    public class CommentController : Controller
    {
        private readonly ICommentService _commentService;
        private readonly ITreatService _treatService;
        public CommentController(ICommentService commentService,ITreatService treatService)
        {
            _commentService= commentService;
            _treatService=treatService;
        }
        public IActionResult Index()
        {
            return View("Create");
        }
        public IActionResult Create()
        {
            var treats= _treatService.GetTreats();
            ViewData["Treats"]= new SelectList(treats,"Id", "TreatName");
            return View();
        }
        [HttpPost]
        public IActionResult Create(CreateCommentRequestModel model)
        {
            int id= int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
            _commentService.CreateComment(model, id);
            return RedirectToAction("Index","Home");
        }
        public IActionResult GetComment(int id)
        {
            var comment= _commentService.GetComment(id);
            return View(comment);
        }
        public IActionResult GetComments()
        {
            return View(_commentService.GetComments());
        }
        public IActionResult GetDispatcherComments()
        {
            return View(_commentService.GetDispatchRiderComments());
        }
        public IActionResult GetTreatsComments()
        {
            return View(_commentService.GetCommentsOnTreats());
        }
        public IActionResult GetOrderComments()
        {
            return View(_commentService.GetOrderRelatedComments());
        }
        public IActionResult GetNegativeComments()
        {
            return View(_commentService.GetNegativeComments());
        }
        public IActionResult GetPositiveComments()
        {
            return View(_commentService.GetPositiveComments());
        }
    }
}