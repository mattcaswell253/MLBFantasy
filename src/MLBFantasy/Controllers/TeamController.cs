using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MLBFantasy.Models;

namespace MLBFantasy.Controllers
{
    public class TeamController : Controller
    {
        private MLBContext db = new MLBContext();
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult NewTeam(string newName, string newNumber, int id)
        {
            Team newTeam = new Team(newName, newNumber, id);
            db.Teams.Add(newTeam);
            db.SaveChanges();
            return Json(newTeam);
        }

    }
}
