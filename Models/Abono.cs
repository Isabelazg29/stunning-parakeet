using System;
using System.Collections.Generic;

namespace Glamping_Addventure2.Models;

public partial class Abono
{
    public int Idabono { get; set; }

    public int? Idreserva { get; set; }

    public DateOnly? FechaAbono { get; set; }

    public double? ValorDeuda { get; set; }

    public double? Porcentaje { get; set; }

    public double? Pendiente { get; set; }

    public double? CantAbono { get; set; }

    public byte[]? Comprobante { get; set; }

    public bool Estado { get; set; }

    public virtual Reserva? IdreservaNavigation { get; set; }
}

