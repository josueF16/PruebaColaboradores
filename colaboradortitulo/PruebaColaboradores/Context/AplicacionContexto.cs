using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

namespace WebApplication2.context
{
    public class AplicacionContexto : DbContext
    {
        public AplicacionContexto
            (DbContextOptions<AplicacionContexto> options)
            : base(options) { }
        public DbSet<Titulo> Titulos { get; set; }
    }
}
