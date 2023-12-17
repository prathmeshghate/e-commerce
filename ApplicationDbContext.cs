
using Entity.productSummary;
using Microsoft.EntityFrameworkCore;

namespace Platform.DbConnection
{

    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){

        }
        
        public DbSet<ProductSummary> productSummary {get; set;}

    }

}