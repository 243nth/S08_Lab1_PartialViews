using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ZombieParty.Models;
using ZombieParty.Models.Data;
using ZombieParty.ViewModels;

namespace ZombieParty.Controllers
{
    public class ZombieTypeController : Controller
    {
        private ZombiePartyDbContext _baseDonnees { get; set; }

        public ZombieTypeController(ZombiePartyDbContext baseDonnees)
        {
            _baseDonnees = baseDonnees;
        }

        public IActionResult Index()
        {
            List<ZombieType> zombieTypesList = _baseDonnees.ZombieTypes.ToList();

            return View(zombieTypesList);
        }

        public IActionResult Details(int id)
        {
            var zombies = _baseDonnees.Zombies.Where(z => z.ZombieTypeId == id);

            ZombieTypeVM zombieTypeVM = new()
            {
                ZombieType = new(),
                ZombiesList = zombies.ToList(),
                ZombiesCount = zombies.Count(),
                PointsAverage = zombies.Average(p => p.Point)
            };

            zombieTypeVM.ZombieType = _baseDonnees.ZombieTypes.FirstOrDefault(zt => zt.Id == id);
            return View(zombieTypeVM);
        }


        //GET CREATE
        public IActionResult Create()
        {
            return View();
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ZombieType zombieType)
        {
            if (ModelState.IsValid)
            {
                // Ajouter à la BD
                _baseDonnees.ZombieTypes.Add(zombieType);
                _baseDonnees.SaveChanges();
                TempData["Success"] = $"{zombieType.TypeName} zombie type added";
                return this.RedirectToAction("Index");
            }

            return this.View(zombieType);
        }

        public IActionResult Edit(int id)
        {
            ZombieType zombieType = _baseDonnees.ZombieTypes.Find(id);
            
            return View(zombieType);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(ZombieType zombieType)
        {
            if (ModelState.IsValid)
            {
                _baseDonnees.ZombieTypes.Update(zombieType);
                _baseDonnees.SaveChanges();
                TempData["Success"] = $"ZombieType {zombieType.TypeName} has been modified";
                return this.RedirectToAction("Index");
            }

            return View(zombieType);
        }

        public IActionResult Delete(int id)
        {
            ZombieType? zombieType = _baseDonnees.ZombieTypes.Find(id);
            if (zombieType == null)
            {
                return NotFound();
            }

            return View(zombieType);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int id)
        {
            ZombieType? zombieType = _baseDonnees.ZombieTypes.Find(id);
            if (zombieType == null)
            {
                return NotFound();
            }

            _baseDonnees.ZombieTypes.Remove(zombieType);
            _baseDonnees.SaveChanges();
            TempData["Success"] = $"ZombieType {zombieType.TypeName} has been removed";
            return RedirectToAction("Index");
        }
    }
}
