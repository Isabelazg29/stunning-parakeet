using Microsoft.AspNetCore.Mvc;
using Glamping_Addventure2.Models;
using System.Linq;
using Microsoft.AspNetCore.Authorization;

namespace Glamping_Addventure2.Controllers
{
    public class PermisosController : Controller
    {
        private readonly GlampingAddventureContext _context;

        public PermisosController(GlampingAddventureContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var permisos = _context.Permisos.ToList();
            return View(permisos);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Permiso permiso)
        {
            if (ModelState.IsValid)
            {
                _context.Permisos.Add(permiso);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(permiso);
        }

        public IActionResult Edit(int id)
        {
            var permiso = _context.Permisos.Find(id);
            if (permiso == null) return NotFound();
            return View(permiso);
        }

        [HttpPost]
        public IActionResult Edit(Permiso permiso)
        {
            if (ModelState.IsValid)
            {
                _context.Permisos.Update(permiso);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(permiso);
        }

        public IActionResult Delete(int id)
        {
            var permiso = _context.Permisos.Find(id);
            if (permiso == null) return NotFound();
            return View(permiso);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var permiso = _context.Permisos.Find(id);
            if (permiso != null)
            {
                _context.Permisos.Remove(permiso);
                _context.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
