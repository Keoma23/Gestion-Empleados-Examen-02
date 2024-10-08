using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Empleados_Examen_02.Interface
{
    public interface IEmpleado
    {
        public Double CalcularSueldo();

        public void MostrarDetalles();
    }
}
