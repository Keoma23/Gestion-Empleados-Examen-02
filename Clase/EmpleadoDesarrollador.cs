using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Empleados_Examen_02.Clase
{
    internal class Desarrollador : EmpleadoBase
    {
        public override double SueldoBase => 3000;

        public override double CalcularSueldo()
        {
            return SueldoBase;
        }
    }
}
