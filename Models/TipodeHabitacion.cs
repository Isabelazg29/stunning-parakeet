using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Glamping_Addventure2.Models;

public partial class TipodeHabitacion
{
    private string? _descripcion;
    private string? _nombreTipodehabitacion;
    public int IdtipodeHabitacion { get; set; }
    [Required(ErrorMessage = "El nombre del tipo de habitacion es obligatorio.")]
    [MinLength(5, ErrorMessage = "El nombre del tipo de habitacion debe tener almenos 5 caracteres.")]
    [Display(Name = "Nombre del tipo de habitacion")]
    public string? NombreTipodeHabitacion
    {
        get => _nombreTipodehabitacion;
        set => _nombreTipodehabitacion = string.IsNullOrEmpty(value)
            ? value
            : char.ToUpper(value[0]) + value.Substring(1);
    }
    [Required(ErrorMessage = "La descripción del tipo de habitacion es obligatoria.")]
    public string? Descripcion
    {
        get => _descripcion;
        set => _descripcion = string.IsNullOrEmpty(value)
            ? value
            : char.ToUpper(value[0]) + value.Substring(1);
    }
    [Required(ErrorMessage = "Confirme que el estado sera activo")]
    public bool Estado { get; set; }

    public virtual ICollection<Habitacion> Habitacions { get; set; } = new List<Habitacion>();
}
