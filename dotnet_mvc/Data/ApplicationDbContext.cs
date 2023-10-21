using dotnet_mvc.Entidades;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace dotnet_mvc.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {

        }
        public ApplicationDbContext( DbContextOptions<ApplicationDbContext> options ) : base( options ) 
        {
           
        }
        public virtual DbSet<Cliente> Clientes { get; set; } = null!;
    }
}
