//Primera parte

//crea una lista de empleados y demuestra la capacidad de
//llamar a métodos polimórficos como CalcularSueldo(), MostrarDetalles() y
//CalcularBonificacion() según el tipo de empleado.

using Gestion_Empleados_Examen_02.Clase;
using Gestion_Empleados_Examen_02.Interface;


Console.WriteLine("Primera Parte");
List<EmpleadoBase> empleados = new List<EmpleadoBase>();
empleados.Add(new Gerente { IdEmpleado=1, Nombre="Juan Perez", Puesto="Gerente"} );
empleados.Add(new Desarrollador { IdEmpleado = 2, Nombre = "Kathy Saavedra", Puesto = "Desarrollador" });

foreach (var empleado in empleados)
{
    empleado.CalcularSueldo();
    empleado.MostrarDetalles();
    if (empleado is ISueldoBonificable empleadoBonificable) {
        Console.WriteLine(empleadoBonificable.CalcularBonificacion());
    }
    Console.WriteLine("");
}

//Segunda parte
//agrega 2 objetos con estos dos nuevos tipos de empleados
empleados.Add(new GerenteRRHH { IdEmpleado = 3, Nombre = "Miguel Lopez", Puesto = "Gerente RRHH" });
empleados.Add(new ConsultorExterno { IdEmpleado = 4, Nombre = "Brayan Diaz", Puesto = "Consultor Externo" });

//Tercera parte
//llama las funciones correspondientes para estas dos nuevas funciones

Console.WriteLine("Tercera Parte");
foreach (var empleado in empleados)
{
    if (empleado is IDescuentoImpuesto empleadoDescuento)
    {
        empleado.MostrarDetalles();
        Console.WriteLine(empleadoDescuento.DescontarSueldo());
    }
    Console.WriteLine("");
}


Console.WriteLine("Quinta Parte");
bool entrarMenú = true; 

while (entrarMenú)
{
    Console.WriteLine("");
    Console.WriteLine("Menú");
    Console.WriteLine("Escribe el numero de las opciones:");
    Console.WriteLine("1. Ingresar Empleado");
    Console.WriteLine("2. Mostrar Listado de Empleado");
    Console.WriteLine("3. Salir");
    int opcion = int.Parse(Console.ReadLine());

    switch (opcion)
    {
        case 1: RegistrarEmpleado(); break;
        case 2: ListarEmpleados(); break;
        case 3: entrarMenú = false; break;
        default: Console.WriteLine("Escribe un numero del Menú"); break;
    }


}

void RegistrarEmpleado()
{
    Console.WriteLine("Escribe el Nombre");
    string Nombre = Console.ReadLine();
    int id = empleados.Count +1 ;
    bool entrarPuesto=true;
    while (entrarPuesto)
    {
        Console.WriteLine("");
        Console.WriteLine("Selecciona un Puesto");
        Console.WriteLine("Escribe el numero del puesto:");
        Console.WriteLine("1. Gerente");
        Console.WriteLine("2. Gerente RRHH");
        Console.WriteLine("3. Consultor Externo");
        Console.WriteLine("4. Desarrollador");
        int opcionPuesto = int.Parse(Console.ReadLine());
        entrarPuesto = false;
        switch (opcionPuesto)
        {
            case 1: empleados.Add(new Gerente { IdEmpleado = id, Nombre = Nombre, Puesto = "Gerente" }); break;
            case 2: empleados.Add(new GerenteRRHH { IdEmpleado = id, Nombre = Nombre, Puesto = "Gerente RRHH" }); break;
            case 3: empleados.Add(new ConsultorExterno { IdEmpleado = id, Nombre = Nombre, Puesto = "Consultor Externo" }); break;
            case 4: empleados.Add(new Desarrollador { IdEmpleado = id, Nombre = Nombre, Puesto = "Desarrollador" }); break;
            default: Console.WriteLine("Escribe un numero del Menú"); entrarPuesto = true; break;
        }
    }
    Console.WriteLine($"Se agrego el empleado {Nombre}");
}

void ListarEmpleados()
{
    double sueldoTotal = 0;
    foreach (var empleado in empleados)
    {
        empleado.MostrarDetalles();
        Console.WriteLine("");
        sueldoTotal += empleado.CalcularSueldo();
    }

    Console.WriteLine($"El numero Total de Empleados es {empleados.Count}");
    Console.WriteLine($"La suma total de Sueldos al mes es {empleados.Sum(empleado => empleado.CalcularSueldo())}");
}