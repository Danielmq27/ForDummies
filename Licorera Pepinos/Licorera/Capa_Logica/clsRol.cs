using Capa_Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Logica
{
    public class clsRol
    {
        public List<VerRolesResult> ConsultarRoles()
        {
            try
            {
                LicoreraDataContext dc = new LicoreraDataContext();
                List<VerRolesResult> data = dc.VerRoles().ToList();
                return data;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
