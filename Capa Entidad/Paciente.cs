using System;
using System.Collections.Generic;

namespace Capa_Entidad;

public partial class Paciente
{
    public int IdPaciente { get; set; }

    public string? NombrePaciente { get; set; }

    public int? Edad { get; set; }

    public string? Genero { get; set; }

    public string? Dni { get; set; }

    public string? Diagnostico { get; set; }

    public DateTime? FechaIngreso { get; set; }

    public virtual ICollection<PacienteServicio> PacienteServicios { get; set; } = new List<PacienteServicio>();
}
