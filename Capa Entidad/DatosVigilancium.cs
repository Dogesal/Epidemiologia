using System;
using System.Collections.Generic;

namespace Capa_Entidad;

public partial class DatosVigilancium
{
    public int IdDatosVigilancia { get; set; }

    public int? Datos { get; set; }

    public string? Descripcion { get; set; }

    public int? IdServicioAntibiotico { get; set; }

    public int? IdServicioMicrobiologia { get; set; }

    public int? IdServicioFuncionesVitales { get; set; }

    public int? IdServicioDispositivoMedico { get; set; }

    public virtual ServicioAntibiotico? IdServicioAntibioticoNavigation { get; set; }

    public virtual ServicioDispositivosMedico? IdServicioDispositivoMedicoNavigation { get; set; }

    public virtual ServicioFuncionesVitale? IdServicioFuncionesVitalesNavigation { get; set; }

    public virtual ServicioMicrobiologium? IdServicioMicrobiologiaNavigation { get; set; }

    public virtual ICollection<Reporte> Reportes { get; set; } = new List<Reporte>();
}
