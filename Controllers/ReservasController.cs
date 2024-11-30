using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Glamping_Addventure.Models;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.Blazor;
using Newtonsoft.Json;
using Humanizer;
using Glamping_Addventure2.Models;

namespace Glamping_Addventure2.Controllers
{
    public class ReservasController : Controller
    {
        private readonly GlampingAddventureContext _context;

        public ReservasController(GlampingAddventureContext context)
        {
            _context = context;
        }

        // GET: Reservas
        public async Task<IActionResult> Index()
        {
            var glampingAddventuresContext = _context.Reservas.Include(r => r.IdEstadoReservaNavigation).Include(r => r.MetodoPagoNavigation).Include(r => r.NroDocumentoClienteNavigation);
            return View(await glampingAddventuresContext.ToListAsync());
        }

        // GET: Reservas/Details/5
        // GET: Reservas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reserva = await _context.Reservas
                .Include(r => r.IdEstadoReservaNavigation)
                .Include(r => r.MetodoPagoNavigation)
                .Include(r => r.NroDocumentoClienteNavigation)
                .Include(r => r.DetalleReservaPaquetes)
                    .ThenInclude(drp => drp.IdpaqueteNavigation)
                .Include(r => r.DetalleReservaServicios)
                    .ThenInclude(drs => drs.IdservicioNavigation)
                .FirstOrDefaultAsync(m => m.IdReserva == id);

            if (reserva == null)
            {
                return NotFound();
            }

            return View(reserva);
        }

        // GET: Reservas/Create
        public IActionResult Create()
        {

            ViewBag.Paquetes = _context.Paquetes.ToList();
            ViewBag.Servicios = _context.Servicios.ToList();
            ViewData["IdEstadoReserva"] = new SelectList(_context.EstadosReservas, "IdEstadoReserva", "IdEstadoReserva");
            ViewData["MetodoPago"] = new SelectList(_context.MetodoPagos, "IdMetodoPago", "NomMetodoPago");
            ViewData["NroDocumentoCliente"] = new SelectList(_context.Clientes, "NroDocumento", "NroDocumento");

            return View();
        }

        // POST: Reservas/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdReserva,NroDocumentoCliente,FechaReserva,FechaInicio,FechaFinalizacion,SubTotal,Descuento,Iva,MontoTotal,MetodoPago,IdEstadoReserva")] Reserva reserva, int paqueteId, string detalleServicios)
        {
            if (ModelState.IsValid)
            {
                using (var transaction = _context.Database.BeginTransaction())
                {
                    try
                    {
                        // Guardar la reserva principal
                        _context.Add(reserva);
                        await _context.SaveChangesAsync();

                        // Guardar el detalle del paquete
                        var detallePaquete = new DetalleReservaPaquete
                        {
                            Idreserva = reserva.IdReserva,
                            Idpaquete = paqueteId,
                            //Precio = _context.Paquetes.FirstOrDefault(p => p.Idpaquete == paqueteId)?.Precio ?? 0
                        };

                        _context.DetalleReservaPaquetes.Add(detallePaquete);
                        await _context.SaveChangesAsync();

                        // Procesar los servicios si se envió el campo JSON
                        if (!string.IsNullOrEmpty(detalleServicios))
                        {
                            var servicios = JsonConvert.DeserializeObject<List<DetalleReservaServicio>>(detalleServicios);

                            foreach (var servicio in servicios)
                            {
                                if (servicio.Idservicio != null && servicio.Cantidad > 0)
                                {
                                    var detalleServicio = new DetalleReservaServicio
                                    {
                                        Idreserva = reserva.IdReserva,
                                        Idservicio = servicio.Idservicio,
                                        Cantidad = servicio.Cantidad,
                                        Precio = servicio.Precio,
                                        Estado = true // Establecer estado inicial
                                    };

                                    _context.DetalleReservaServicios.Add(detalleServicio);
                                }
                            }

                            await _context.SaveChangesAsync();
                        }

                        // Confirmar la transacción
                        await transaction.CommitAsync();
                        return RedirectToAction(nameof(Index));
                    }
                    catch (Exception ex)
                    {
                        await transaction.RollbackAsync();
                        // Registrar el error
                        ModelState.AddModelError("", "Error al guardar la reserva: " + ex.Message);
                    }
                }
            }

            // Si algo falló, redisplay del formulario con datos necesarios para los dropdowns
            ViewData["IdEstadoReserva"] = new SelectList(_context.EstadosReservas, "IdEstadoReserva", "IdEstadoReserva", reserva.IdEstadoReserva);
            ViewData["MetodoPago"] = new SelectList(_context.MetodoPagos, "IdMetodoPago", "NomMetodoPago", reserva.MetodoPago);
            ViewData["NroDocumentoCliente"] = new SelectList(_context.Clientes, "NroDocumento", "NroDocumento", reserva.NroDocumentoCliente);
            return View(reserva);
        }




        [HttpGet]
        public async Task<IActionResult> ObtenerClientePorDocumento(string documento)
        {
            var cliente = await _context.Clientes
                                        .Where(c => c.NroDocumento == documento)
                                        .Select(c => new
                                        {
                                            c.Nombre,
                                            c.Apellido,
                                            c.Email, // Verifica que el campo aquí corresponda con el nombre en tu modelo
                                            c.Telefono
                                        })
                                        .FirstOrDefaultAsync();

            if (cliente != null)
            {
                return Json(new { success = true, data = cliente });
            }
            else
            {
                return Json(new { success = false });
            }
        }
        public async Task<IActionResult> AgregarAbono(int id)
        {
            var reserva = await _context.Reservas.FindAsync(id);
            if (reserva == null)
            {
                return NotFound();
            }

            // Crear un nuevo abono y asignar la reserva
            var abono = new Abono { Idreserva = id };
            return View("CreateAbono", abono); // Asegúrate de tener una vista CreateAbono
        }

        // GET: Reservas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reserva = await _context.Reservas
                .Include(r => r.DetalleReservaPaquetes)
                .Include(r => r.DetalleReservaServicios)
                .FirstOrDefaultAsync(m => m.IdReserva == id);

            if (reserva == null)
            {
                return NotFound();
            }

            ViewData["IdEstadoReserva"] = new SelectList(_context.EstadosReservas, "IdEstadoReserva", "IdEstadoReserva", reserva.IdEstadoReserva);
            ViewData["MetodoPago"] = new SelectList(_context.MetodoPagos, "IdMetodoPago", "NomMetodoPago", reserva.MetodoPago);
            ViewData["NroDocumentoCliente"] = new SelectList(_context.Clientes, "NroDocumento", "NroDocumento", reserva.NroDocumentoCliente);
            ViewBag.Paquetes = _context.Paquetes.ToList();
            ViewBag.Servicios = _context.Servicios.ToList();

            return View(reserva);
        }

        // POST: Reservas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Reserva reserva, List<int> serviciosIds, List<int> cantidadesServicios)
        {
            if (id != reserva.IdReserva)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var reservaExistente = await _context.Reservas
                        .Include(r => r.DetalleReservaServicios)
                        .FirstOrDefaultAsync(r => r.IdReserva == id);

                    if (reservaExistente != null)
                    {
                        // Actualizar datos básicos
                        _context.Entry(reservaExistente).CurrentValues.SetValues(reserva);

                        // Actualizar servicios
                        reservaExistente.DetalleReservaServicios.Clear();
                        for (int i = 0; i < serviciosIds.Count; i++)
                        {
                            reservaExistente.DetalleReservaServicios.Add(new DetalleReservaServicio
                            {
                                Idservicio = serviciosIds[i],
                                Cantidad = cantidadesServicios[i],
                            });
                        }

                        await _context.SaveChangesAsync();
                    }
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReservaExists(reserva.IdReserva))
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

            // Si falla la validación, recargar datos
            ViewData["IdEstadoReserva"] = new SelectList(_context.EstadosReservas, "IdEstadoReserva", "NomEstadoReserva", reserva.IdEstadoReserva);
            ViewData["MetodoPago"] = new SelectList(_context.MetodoPagos, "IdMetodoPago", "NomMetodoPago", reserva.MetodoPago);
            ViewData["NroDocumentoCliente"] = new SelectList(_context.Clientes, "NroDocumento", "NroDocumento", reserva.NroDocumentoCliente);
            return View(reserva);
        }

        // GET: Reservas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reserva = await _context.Reservas
                .Include(r => r.IdEstadoReservaNavigation)
                .Include(r => r.MetodoPagoNavigation)
                .Include(r => r.NroDocumentoClienteNavigation)
                .FirstOrDefaultAsync(m => m.IdReserva == id);
            if (reserva == null)
            {
                return NotFound();
            }

            return View(reserva);
        }

        // POST: Reservas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var reserva = await _context.Reservas.FindAsync(id);
            if (reserva != null)
            {
                _context.Reservas.Remove(reserva);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReservaExists(int id)
        {
            return _context.Reservas.Any(e => e.IdReserva == id);
        }
    }
}
