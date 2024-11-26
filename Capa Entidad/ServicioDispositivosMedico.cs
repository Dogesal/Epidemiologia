using System;
using System.Collections.Generic;

namespace Capa_Entidad;

public partial class ServicioDispositivosMedico
{
    public int IdServicioDispositivosMedicos { get; set; }

    public int? IdSevicio { get; set; }

    public int? IdDispositivosMedicos { get; set; }

    public virtual ICollection<DatosVigilancium> DatosVigilancia { get; set; } = new List<DatosVigilancium>();

    public virtual DispositivosMedico? IdDispositivosMedicosNavigation { get; set; }

    public virtual Servicio? IdSevicioNavigation { get; set; }
}
