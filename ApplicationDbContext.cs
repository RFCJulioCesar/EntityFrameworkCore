using Microsoft.EntityFrameworkCore;

namespace mi_primer_conexion_BD
{
    public class ApplicationDbContext : DbContext
    {
        protected ApplicationDbContext(DbContextOptions dbContextOptions): base(dbContextOptions) 
        {

        }
    }
}
    