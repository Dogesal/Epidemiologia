using System;
using System.Collections.Generic;

namespace Capa_Entidad;

public partial class Microbiologium
{
    public int IdMicrobiologia { get; set; }

    public string? NombreMicrobiologia { get; set; }

    public virtual ICollection<ServicioMicrobiologium> ServicioMicrobiologia { get; set; } = new List<ServicioMicrobiologium>();
}
