using dotnet_mvc.Entidades;
using dotnet_mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_mvc.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase 
    {
        public ClienteModel clienteModel = new ClienteModel();

        private readonly ILogger<ClienteController> _logger;
        

        public ClienteController(ILogger<ClienteController> logger)
        {
            _logger = logger;
        }
        
        [HttpGet(Name = "GetCliente")]
        public Cliente Get()
        {
            return clienteModel.getCliente();
            
        }

    }
}
