using Microsoft.AspNetCore.Mvc;
using CriminalManagementSystem.Models;
using CriminalManagementSystem.Services;
using MongoDB.Driver;

namespace CriminalManagementSystem.Controllers
{
    public class FIRController : Controller
    {
        private readonly MongoDBService _mongoDBService;

        public FIRController(MongoDBService mongoDBService)
        {
            _mongoDBService = mongoDBService;
        }

        public IActionResult Index()
        {
            var firs = _mongoDBService.FIRs
                .Find(_ => true)
                .ToList();

            return View(firs);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(FIR fir)
        {
            _mongoDBService.FIRs.InsertOne(fir);

            return RedirectToAction("Index");
        }
    }
}