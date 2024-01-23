namespace RepasoActividadClientes.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public int menuVersion()
        {
            Console.WriteLine("ELIGE LA VERSION QUE DESEAS USAR");
            Console.WriteLine("1. Cerrar aplicacion");
            Console.WriteLine("2. Version empleado");
            Console.WriteLine("3. Version cliente");
            int seleccion = Convert.ToInt32(Console.ReadLine());
            return seleccion;
        }

        public int menuEmpleado()
        {
            Console.WriteLine("OPCIONES (VERSION EMPLEADO)");
            Console.WriteLine("1. Cerrar version empleado");
            Console.WriteLine("2. Validar cliente");
            Console.WriteLine("3. Borrado de cliente");
            Console.WriteLine("4. Mostrar cliente");
            int seleccion = Convert.ToInt32(Console.ReadLine());
            return seleccion;
        }

        public int menuCliente()
        {
            Console.WriteLine("OPCIONES (VERSION CLIENTE)");
            Console.WriteLine("1. Cerrar version cliente");
            Console.WriteLine("2. Registro cliente");
            Console.WriteLine("3. Acceso cliente (Login)");
            int seleccion = Convert.ToInt32(Console.ReadLine());
            return seleccion;
        }
    }
}
