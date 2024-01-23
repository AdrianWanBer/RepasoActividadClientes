using RepasoActividadClientes.Dto;

namespace RepasoActividadClientes.Servicios
{
    internal class EmpleadoImplementacion : EmpleadoInterfaz
    {
        public void validarCliente(List<ClienteDto> listaCliente)
        {
            Console.WriteLine("CLIENTES NO VALIDADOS");
            foreach (ClienteDto cliente in listaCliente)
            {
                if (cliente.EsValidado == false)
                {
                    Console.WriteLine(@"\\\\\\\\\\");
                    Console.WriteLine("DNI: " + cliente.DniCliente);
                    Console.WriteLine("NOMBRE COMPLETO: " + cliente.NombreCompletoCliente);
                    Console.WriteLine(@"\\\\\\\\\\");
                }
            }
            Console.WriteLine("Indica el dni del cliente a validar");
            string dniClienteAValidar = Console.ReadLine();
            foreach (ClienteDto cliente in listaCliente)
            {
                if (cliente.DniCliente.Equals(dniClienteAValidar))
                {
                    cliente.EsValidado = true;
                    Console.WriteLine("El cliente: " + dniClienteAValidar + " ha sido validado");
                }
            }

        }
    }
}
