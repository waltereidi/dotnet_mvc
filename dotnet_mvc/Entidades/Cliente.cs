using Microsoft.EntityFrameworkCore;

namespace dotnet_mvc.Entidades
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Descricao { get; set; } 

        public DbSet<NestedTest> NestedTest { get; set; }
    }
}
