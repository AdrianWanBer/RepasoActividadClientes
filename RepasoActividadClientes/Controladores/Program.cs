using RepasoActividadClientes.Dto;
using RepasoActividadClientes.Servicios;

namespace RepasoActividadClientes.Controladores
{
    class program
    {
        public static void Main(string[] args)
        {

            MenuInterfaz mi = new MenuImplementacion();
            List<ClienteDto> listaCliente = new List<ClienteDto>();
            EmpleadoInterfaz ei = new EmpleadoImplementacion();
            bool cerrarAplicacion = false;
            while (!cerrarAplicacion)
            {
                int seleccion = mi.menuVersion();
                switch (seleccion)
                {
                    case 1: // Cerrar aplicacion
                        cerrarAplicacion = true;
                        break;

                    case 2: // Abrir version empleado
                        bool cerrarVersionEmpleado = false;
                        while (!cerrarVersionEmpleado)
                        {
                            int seleccionEmpleado = mi.menuEmpleado();
                            switch (seleccionEmpleado)
                            {
                                case 1: //Cerrar aplicacion
                                    cerrarVersionEmpleado = true;

                                    break;
                                case 2: //Validar cliente
                                    ei.validarCliente(listaCliente);
                                    break;
                                case 3: //Borrado de cliente

                                    break;
                                case 4: //Mostrar clientes

                                    break;
                                default: //default
                                    Console.WriteLine("Opcion no valida");
                                    break;
                            }
                        }
                        break;
                    case 3: // Abrir version de cliente
                        bool cerrarVersionCliente = false;
                        while (!cerrarVersionCliente)
                        {
                            int seleccionCliente = mi.menuCliente();
                            switch (seleccion)
                            {
                                case 1: //Cerrar menu
                                    cerrarVersionCliente = true;

                                    break;
                                case 2: //Registro cliente

                                    break;
                                case 3: //Acceso cliente

                                    break;



                                default: //default
                                    Console.WriteLine("Opcion no valida");
                                    break;
                            }
                        }
                        break;
                    default: //default
                        Console.WriteLine("Opcion no valida");
                        break;
                }
            }
        }
    }
}