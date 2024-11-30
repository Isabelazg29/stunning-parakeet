using System;
using System.Collections.Generic;

namespace Glamping_Addventure2.Models;

public partial class PaquetesServicio
{
    public int IdpaquetesServicio { get; set; }

    public int? Idpaquete { get; set; }

    public int? Idservicio { get; set; }

    public virtual Paquete? IdpaqueteNavigation { get; set; }

    public virtual Servicio? IdservicioNavigation { get; set; }
}
