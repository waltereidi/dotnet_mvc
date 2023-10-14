using dotnet_mvc.Entidades;

namespace dotnet_mvc.Models
{
    public class ClienteModel
    {
        public Cliente getCliente()
        {
            return new Cliente() { Id=1 , Descricao="Desc"};

        }
    }
}
