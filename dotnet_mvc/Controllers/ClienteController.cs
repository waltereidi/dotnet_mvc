using dotnet_mvc.Data;
using dotnet_mvc.Entidades;
using dotnet_mvc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace dotnet_mvc.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase 
    {
        public ClienteModel clienteModel = new ClienteModel();
        private readonly ApplicationDbContext _context; 
        private readonly ILogger<ClienteController> _logger;
        

        public ClienteController(ILogger<ClienteController> logger , ApplicationDbContext context )
        {
            _logger = logger;
            _context = context;
        }
        
        [HttpGet(Name = "GetCliente")]
        public List<Cliente> Get()
        {
            List<Cliente> listClientes = _context.Clientes.ToList();
            List<NestedTest> nestedTests = _context.NestedTest.ToList();
            return listClientes;
                
        }

    }
}
