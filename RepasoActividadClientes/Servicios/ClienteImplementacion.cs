using RepasoActividadClientes.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoActividadClientes.Servicios
{
    internal class ClienteImplementacion : ClienteInterfaz
    {
        public void registrarNuevoCliente(List<ClienteDto> listaClientes)
        {

            int id = calcularNuevoId(listaClientes);
            Console.WriteLine("Indique el DNI: ");
            string dni = Console.ReadLine();
            Console.WriteLine("Indique el Nombre completo: ");
            string nombreConEspacios = Console.ReadLine();
            Console.WriteLine("Indique el email: ");
            string emailCliente = Console.ReadLine();
            Console.WriteLine("Indique la contraseña: ");
            string contraseñaCliente = Console.ReadLine();




            ClienteDto nuevoCliente = new ClienteDto(id, dni, nombreConEspacios, emailCliente, contraseñaCliente);
            listaClientes.Add(nuevoCliente);
        }

        private int calcularNuevoId(List <ClienteDto> listaCliente)
        {
            int idCalculado;
            int tamañoLista = listaCliente.Count;
            if (tamañoLista == 0)
            {
                idCalculado = 0;
            }
            else
            {
                idCalculado = listaCliente[tamañoLista - 1].IdCliente + 1;
            }


            return idCalculado;
        }
    }
}
