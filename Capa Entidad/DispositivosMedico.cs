using System;
using System.Collections.Generic;

namespace Capa_Entidad;

public partial class DispositivosMedico
{
    public int IdDispositivosMedicos { get; set; }

    public string? NombreDispositivosMedicos { get; set; }

    public virtual ICollection<ServicioDispositivosMedico> ServicioDispositivosMedicos { get; set; } = new List<ServicioDispositivosMedico>();
}
