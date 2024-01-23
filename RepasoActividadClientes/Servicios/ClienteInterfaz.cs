using RepasoActividadClientes.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoActividadClientes.Servicios
{
    internal interface ClienteInterfaz
    {
        public void registrarNuevoCliente(List<ClienteDto> listaClientes);
    }
}
