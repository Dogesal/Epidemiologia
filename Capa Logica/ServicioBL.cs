using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Threading.Tasks;
using Capa_Entidad;
using Microsoft.EntityFrameworkCore;

namespace Capa_Logica
{
    public class ServicioBL
    {
        private readonly RepEpidemiologiaContext _dbcontext;
        public ServicioBL(RepEpidemiologiaContext dbcontext) {

            _dbcontext = dbcontext;

        }

        public IEnumerable<object> ListServicio()
        {
            try
            {
                // Proyección de los datos a un objeto anónimo
                var servicios = _dbcontext.Servicios
                    .Select(s => new
                    {
                        idServicios = s.IdServicios,
                        nombreServicios = s.NombreServicios
                    })
                    .ToList();

                return servicios;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al listar los servicios: {ex.Message}");
            }
        }


        public object AddServicio(Servicio servicio)
        {
            try
            {
                _dbcontext.Servicios.Add(servicio);
                _dbcontext.SaveChanges();

                // Retornar un objeto con los datos requeridos
                return new
                {
                    idServicios = servicio.IdServicios,
                    nombreServicios = servicio.NombreServicios // Opcional si necesitas devolver ambos
                };
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al agregar el servicio: {ex.Message}");
            }
        }


        public Servicio DeleteServicio(int id)
        {
            try
            {
                var servicio = _dbcontext.Servicios.Find(id);
                _dbcontext.Servicios.Remove(servicio);
                _dbcontext.SaveChanges();

                return servicio;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }

    }
}
