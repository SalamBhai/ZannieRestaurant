using Microsoft.AspNetCore.Mvc;
using Cakes_N_Treats_By_Zannie.Interfaces.IServices;
using Cakes_N_Treats_By_Zannie.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using System;
using Microsoft.AspNetCore.Authorization;

namespace Cakes_N_Treats_By_Zannie.Controllers
{
    public class TreatController  : Controller
    {
        private readonly ITreatService TreatService;
        private readonly ICategoryService _CategoryService;
        private readonly IWebHostEnvironment _webhostEnvironment;
        public TreatController(ITreatService treatservice, ICategoryService categoryservice,IWebHostEnvironment webhostEnvironment)
        {
            TreatService=treatservice;
            _CategoryService=categoryservice;
            _webhostEnvironment=webhostEnvironment;
        }
        public IActionResult Index()
        {
            return View();
        }
        
         [Authorize(Roles="Administrator")]
        public IActionResult CreateTreat()
        {
            var categories= _CategoryService.GetCategories();
            ViewData["Categories"]= new SelectList(categories,"id", "CategoryName");
            return View();
        }
        [HttpPost]
        public IActionResult CreateTreat(CreateTreatRequestModel model, IFormFile TreatPhoto)
        {
            string path= Path.Combine(_webhostEnvironment.WebRootPath, "TreatPhoto");
            Directory.CreateDirectory(path);
            string contenttype= TreatPhoto.ContentType.Split('/')[1];
            string treatimage= $"Treat{Guid.NewGuid().ToString().Substring(1, 7)}.{contenttype}";
            string fullpath= Path.Combine(path,treatimage);
            using (var filestream= new FileStream(fullpath, FileMode.Create))
            {
                 TreatPhoto.CopyTo(filestream);
            }
            model.TreatPhoto=treatimage;
            TreatService.CreateTreatRequest(model);
            return RedirectToAction("GetTreats");
        }
        public IActionResult GetTreats()
        {
            var treatstosee= TreatService.GetTreats();
            return View(treatstosee);
        }
        public IActionResult GetFullDetailsOfTreat(int id)
        {
            var treatyouwannasee= TreatService.GetTreatRequest(id);
            if(treatyouwannasee==null)
            {
                return NotFound();
            }
           return View(treatyouwannasee);
        }
         [Authorize(Roles="Administrator")]
        public IActionResult UpdateTreat(int id)
        {
            var treattoupdateforrequest= TreatService.GetTreatRequest(id);
            if(treattoupdateforrequest== null)
            {
                return NotFound("Treat Not Found");
            }
            return View();

        }
        [HttpPost]
        public IActionResult UpdateTreat(int id,UpdateTreatRequestModel model)
        {
            TreatService.UpdateTreat(id,model);
            return RedirectToAction("Index");
        }
         [Authorize(Roles="Administrator")]
        public IActionResult DeleteTreat(int id)
        {
            var treattodelete= TreatService.GetTreatRequest(id);
            if(treattodelete==null)
            {
              return NotFound("Treat Not Found");
            }
            return View(treattodelete);
        }
        [HttpPost,ActionName("DeleteTreat")]
        public IActionResult DeleteConfirmed(int id)
        {
            TreatService.DeleteTreat(id);
            return RedirectToAction("DeletionSuccess");
        }
        public IActionResult DeletionSuccess()
        {
            return View();
        }
        public IActionResult FindTreatByName(string Name)
        {
            var doesit=TreatService.FindExistenceoftreatbyname(Name);
            if(doesit!=true)
            {
                return NotFound("No! This Treat does Not Exist");
            }
            return View(doesit);
        }
        [Authorize(Roles="Administrator")]
        public IActionResult DiscreteIndex()
        {
            var treats= TreatService.GetTreats();
            return View(treats);
        }
        public IActionResult TreatInfo()
        {
            var treats=TreatService.GetTreats();
            return View(treats);
        }
       
    }
}