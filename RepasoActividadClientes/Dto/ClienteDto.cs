namespace RepasoActividadClientes.Dto
{
    internal class ClienteDto
    {
        int idCliente;
        string dniCliente;
        string nombreCliente;
        string apellido1Cliente;
        string apellido2Cliente;
        string nombreCompletoCliente;
        string emailCliente;
        string contraseniaCliente;
        bool esValidado = false;

        public int IdCliente { get => idCliente; set => idCliente = value; }
        public string DniCliente { get => dniCliente; set => dniCliente = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string Apellido1Cliente { get => apellido1Cliente; set => apellido1Cliente = value; }
        public string Apellido2Cliente { get => apellido2Cliente; set => apellido2Cliente = value; }
        public string NombreCompletoCliente { get => nombreCompletoCliente; set => nombreCompletoCliente = value; }
        public string EmailCliente { get => emailCliente; set => emailCliente = value; }
        public string ContraseniaCliente { get => contraseniaCliente; set => contraseniaCliente = value; }
        public bool EsValidado { get => esValidado; set => esValidado = value; }

        public ClienteDto(int idCliente, string dniCliente, string nombreCliente, string apellido1Cliente, string apellido2Cliente, string nombreCompletoCliente, string emailCliente, string contraseniaCliente)
        {
            this.dniCliente = dniCliente;
            this.nombreCompletoCliente = nombreCompletoCliente;
            string[] arrayNombre = nombreCompletoCliente.Split(' ');
            this.nombreCliente = arrayNombre[0];
            this.apellido1Cliente = arrayNombre[1];
            this.apellido2Cliente = arrayNombre[2];
            this.emailCliente = emailCliente;
            this.contraseniaCliente = contraseniaCliente;
            this.idCliente = idCliente;
        }

        public ClienteDto()
        {

        }
    }
}
