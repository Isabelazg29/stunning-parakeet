using Microsoft.AspNetCore.Mvc;
using Glamping_Addventure2.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace Glamping_Addventure2.Controllers
{
    
    public class RolesController : Controller
    {
        private readonly GlampingAddventureContext _context;

        public RolesController(GlampingAddventureContext context)
        {
            _context = context;
        }

        
        public IActionResult Index()
        {
            var roles = _context.Roles.Include(r => r.RolesPermisos).ToList();
            return View(roles);
        }

        
        [HttpPost]
        [Route("Roles/ToggleActive")]
        public IActionResult ToggleActive(int id)
        {
            try
            {
                var role = _context.Roles.FirstOrDefault(r => r.Idrol == id);
                if (role != null)
                {
                    role.IsActive = !role.IsActive;
                    _context.Update(role);
                    _context.SaveChanges();
                    return Json(new { success = true, estado = role.IsActive });
                }
                return Json(new { success = false });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = "Error al cambiar el estado: " + ex.Message });
            }
        }


        
        public IActionResult Create()
        {
            ViewBag.Permisos = _context.Permisos.ToList();
            return View();
        }

        [HttpPost]

        [ValidateAntiForgeryToken]
        public IActionResult Create(Role role, int[] selectedPermisos, bool isActive)
        {
            if (_context.Roles.Any(r => r.Nombre == role.Nombre))
            {
                ModelState.AddModelError("Nombre", "Ya existe un rol con este nombre.");
            }

            if (selectedPermisos == null || !selectedPermisos.Any())
            {
                ModelState.AddModelError("Permisos", "Debe seleccionar al menos un permiso.");
            }

            if (ModelState.IsValid)
            {
                role.IsActive = isActive;
                _context.Roles.Add(role);
                _context.SaveChanges();

                foreach (var permisoId in selectedPermisos)
                {
                    var rolPermiso = new RolesPermiso
                    {
                        Idrol = role.Idrol,
                        Idpermiso = permisoId
                    };
                    _context.RolesPermisos.Add(rolPermiso);
                }
                _context.SaveChanges();

                TempData["Success"] = "Rol creado exitosamente.";
                return RedirectToAction(nameof(Index));
            }

            ViewBag.Permisos = _context.Permisos.ToList();
            return View(role);
        }

        
        public IActionResult Edit(int id)
        {
            var role = _context.Roles.Include(r => r.RolesPermisos).FirstOrDefault(r => r.Idrol == id);
            if (role == null)
            {
                return NotFound();
            }

            ViewBag.Permisos = _context.Permisos.ToList();
            ViewBag.PermisosAsignados = role.RolesPermisos.Select(p => p.Idpermiso).ToList();

            return View(role);
        }

        [HttpPost]

        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Role role, int[] selectedPermisos, bool isActive)
        {
            if (id != role.Idrol)
            {
                return NotFound();
            }

            if (_context.Roles.Any(r => r.Nombre == role.Nombre && r.Idrol != id))
            {
                ModelState.AddModelError("Nombre", "Ya existe un rol con este nombre.");
            }

            if (ModelState.IsValid)
            {
                try
                {
                    role.IsActive = isActive;
                    _context.Update(role);
                    _context.SaveChanges();

                    // Actualizar permisos
                    var existingPermissions = _context.RolesPermisos.Where(rp => rp.Idrol == id).ToList();
                    _context.RolesPermisos.RemoveRange(existingPermissions);

                    foreach (var permisoId in selectedPermisos)
                    {
                        var rolPermiso = new RolesPermiso
                        {
                            Idrol = role.Idrol,
                            Idpermiso = permisoId
                        };
                        _context.RolesPermisos.Add(rolPermiso);
                    }
                    _context.SaveChanges();

                    TempData["Success"] = "Rol actualizado exitosamente.";
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_context.Roles.Any(e => e.Idrol == role.Idrol))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }

            ViewBag.Permisos = _context.Permisos.ToList();
            ViewBag.PermisosAsignados = selectedPermisos;
            return View(role);
        }

        
        public IActionResult Delete(int id)
        {
            var rol = _context.Roles
                              .Include(r => r.RolesPermisos)
                              .FirstOrDefault(r => r.Idrol == id);

            if (rol == null)
            {
                return NotFound();
            }

            var usuariosConRol = _context.Usuarios.Where(u => u.Idrol == id).ToList();
            ViewBag.HasUsers = usuariosConRol.Any();

            return View(rol);
        }


        
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var rol = _context.Roles.Include(r => r.RolesPermisos).FirstOrDefault(r => r.Idrol == id);
            if (rol == null)
            {
                return NotFound();
            }

            var usuariosConRol = _context.Usuarios.Where(u => u.Idrol == id).ToList();
            if (usuariosConRol.Any())
            {
                return Json(new { success = false, message = "No se puede eliminar el rol porque tiene usuarios asociados." });
            }

            _context.RolesPermisos.RemoveRange(rol.RolesPermisos);
            _context.Roles.Remove(rol);
            _context.SaveChanges();

            TempData["Success"] = "Rol eliminado exitosamente.";
            return RedirectToAction(nameof(Index));
        }
    }
}
