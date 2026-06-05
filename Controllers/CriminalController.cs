using Microsoft.AspNetCore.Mvc;
using CriminalManagementSystem.Models;
using CriminalManagementSystem.Services;
using MongoDB.Driver;

namespace CriminalManagementSystem.Controllers
{
    public class CriminalController : Controller
    {
        private readonly MongoDBService _mongoDBService;

        public CriminalController(MongoDBService mongoDBService)
        {
            _mongoDBService = mongoDBService;
        }

        public IActionResult Index()
        {
            var criminals = _mongoDBService.Criminals
                .Find(_ => true)
                .ToList();

            return View(criminals);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Criminal criminal)
        {
            _mongoDBService.Criminals.InsertOne(criminal);

            return RedirectToAction("Index");
        }
    }
}