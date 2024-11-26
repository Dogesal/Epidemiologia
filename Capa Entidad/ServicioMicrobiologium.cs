using System;
using System.Collections.Generic;

namespace Capa_Entidad;

public partial class ServicioMicrobiologium
{
    public int IdServicioMicrobiologia { get; set; }

    public int? IdServicio { get; set; }

    public int? IdMicrobiologia { get; set; }

    public virtual ICollection<DatosVigilancium> DatosVigilancia { get; set; } = new List<DatosVigilancium>();

    public virtual Microbiologium? IdMicrobiologiaNavigation { get; set; }

    public virtual Servicio? IdServicioNavigation { get; set; }
}
