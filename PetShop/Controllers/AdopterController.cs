﻿using Microsoft.AspNetCore.Mvc;
using PetShop.Data.Data;
using PetShop.Model.Models;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Controllers
{
    public class AdopterController : Controller
    {
        private readonly ApplicationDbContext _db;
        public AdopterController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var ObjList = _db.Adopters.ToList();
            return View(ObjList);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Adopter obj)
        {
            if (ModelState.IsValid)
            {
                _db.Add(obj);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var ob = await _db.Adopters.FindAsync(id);
            return View(ob);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Adopter ob)
        {
            if (ModelState.IsValid)
            {
                _db.Update(ob);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(ob);
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var obj = await _db.Adopters.FindAsync(id);
            return View(obj);
        }
        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var obj = await _db.Adopters.FindAsync(id);
            _db.Adopters.Remove(obj);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
