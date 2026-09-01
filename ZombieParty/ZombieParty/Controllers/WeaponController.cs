using Microsoft.AspNetCore.Mvc;
using ZombieParty.Models;
using ZombieParty.Models.Data;
using ZombieParty.ViewModels;

namespace ZombieParty.Controllers
{
    public class WeaponController : Controller
    {
        private ZombiePartyDbContext _baseDonnees { get; set; }

        public WeaponController(ZombiePartyDbContext baseDonnees)
        {
            _baseDonnees = baseDonnees;
        }

        public IActionResult Index()
        {
            List<Weapon> weapons = _baseDonnees.Weapons.ToList();
            return View(weapons);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Weapon weapon)
        {
            if (ModelState.IsValid)
            {
                // Ajouter à la BD
                _baseDonnees.Weapons.Add(weapon);
                TempData["Success"] = $"{weapon.Name} weapon added";

                _baseDonnees.SaveChanges();

                return this.RedirectToAction("Index");
            }

            return this.View(weapon);
        }
    }
}
