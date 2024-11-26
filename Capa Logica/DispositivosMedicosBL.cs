using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entidad;

namespace Capa_Logica
{

   
    internal class DispositivosMedicosBL
    {
        private readonly RepEpidemiologiaContext _dbcontext;
        public DispositivosMedicosBL(RepEpidemiologiaContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public IEnumerable<DispositivosMedico> listDispositivoMedico()
        {
            return _dbcontext.DispositivosMedicos.ToList();
        }



    }
}
