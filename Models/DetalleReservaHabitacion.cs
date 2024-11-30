using System;
using System.Collections.Generic;

namespace Glamping_Addventure2.Models;

public partial class DetalleReservaHabitacion
{
    public int IddetalleReservaHabitacion { get; set; }

    public int? Idreserva { get; set; }

    public int? Cantidad { get; set; }

    public int? Precio { get; set; }

    public string? Estado { get; set; }

    public int? Idhabitacion { get; set; }

    public virtual Habitacion? IdhabitacionNavigation { get; set; }

    public virtual Reserva? IdreservaNavigation { get; set; }
}
