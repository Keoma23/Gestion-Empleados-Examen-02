using Gestion_Empleados_Examen_02.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Empleados_Examen_02.Clase
{
    internal class GerenteRRHH : EmpleadoBase, ISueldoBonificable
    {
        public override double SueldoBase => 8000;

        public override void MostrarDetalles()
        {
            base.MostrarDetalles();
            Console.WriteLine($"Con una bonificacion de {CalcularBonificacion()} y un descuento de {DescontarSueldo()} ");
            Console.WriteLine($"Su sueldo final es {CalcularSueldo()} ");
        }

        public double CalcularBonificacion()
        {
            return 1000;
        }

        public override double CalcularSueldo()
        {
            return SueldoBase+CalcularBonificacion()-DescontarSueldo();
        }

        public double DescontarSueldo()
        {
            
            return Constante.Descuento10 * SueldoBase;
        }
    }
}
