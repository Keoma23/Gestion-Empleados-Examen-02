using Gestion_Empleados_Examen_02.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Empleados_Examen_02.Clase
{
    public abstract class EmpleadoBase : IEmpleado
    {
        public string Nombre { get; set; }
        public int IdEmpleado { get; set; }
        public string Puesto { get; set; }
        public abstract double SueldoBase { get;}
        public abstract double CalcularSueldo();

        public virtual void MostrarDetalles()
        {
            Console.WriteLine($"El empleado {Nombre}, tiene un puesto de {Puesto} y un sueldo base de {SueldoBase}");
        }
    }
}
