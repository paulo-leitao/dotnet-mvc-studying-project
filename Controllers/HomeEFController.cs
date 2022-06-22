using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using mvc_web_app.Models;

namespace mvc_web_app.Controllers
{
    public class HomeEFController : Controller
    {
        private ArchiveDbContext _context;

        public HomeEFController(ArchiveDbContext context){
            _context = context;
        }

        public IActionResult Index(){
            var archive = _context.Archive.ToList();
            return View(archive);
        }

        //Get
        public IActionResult Create(){
            return View();
        }
        //Post
        [HttpPost]
        public IActionResult Create(Archive archive){
            _context.Add(archive);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        
        //Get
        public IActionResult Edit(int id){
            if (id == null)
            {
                return NotFound();
            }
            var archive = _context.Archive.SingleOrDefault(a => a.ID == id);
            if (archive == null){
                return NotFound();
            }
            return View(archive);
        }

        //Post
        [HttpPost]
        public IActionResult Edit(int id, Archive archive){
            if (id != archive.ID){
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                _context.Update(archive);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(archive);
        }

        //Get
        public IActionResult Delete(int id){
            if (id == null)
            {
                return NotFound();
            }
            var archive = _context.Archive.SingleOrDefault(a => a.ID == id);
            if (archive == null){
                return NotFound();
            }
            return View(archive);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirm(int id){
            var archive = _context.Archive.SingleOrDefault(a => a.ID == id);
            if (archive == null)
            {
                return NotFound();
            }
            _context.Remove(archive);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id){
            if (id == null)
            {
                return NotFound();
            }
            var archive = _context.Archive.SingleOrDefault(a => a.ID == id);
            if (archive == null){
                return NotFound();
            }
            return View(archive);
        }

    }
}
