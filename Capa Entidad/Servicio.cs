using System;
using System.Collections.Generic;

namespace Capa_Entidad;

public partial class Servicio
{
    public int IdServicios { get; set; }

    public string? NombreServicios { get; set; }

    public virtual ICollection<PacienteServicio> PacienteServicios { get; set; } = new List<PacienteServicio>();

    public virtual ICollection<ServicioAntibiotico> ServicioAntibioticos { get; set; } = new List<ServicioAntibiotico>();

    public virtual ICollection<ServicioDispositivosMedico> ServicioDispositivosMedicos { get; set; } = new List<ServicioDispositivosMedico>();

    public virtual ICollection<ServicioFuncionesVitale> ServicioFuncionesVitales { get; set; } = new List<ServicioFuncionesVitale>();

    public virtual ICollection<ServicioMicrobiologium> ServicioMicrobiologia { get; set; } = new List<ServicioMicrobiologium>();
}
