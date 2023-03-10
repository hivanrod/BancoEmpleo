using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;

namespace ApiBancoEmpleo
{

    public class ApiBancoEmpleoDbContextFactory : IDesignTimeDbContextFactory<ApiBancoEmpleoDbContext>
    {
        public ApiBancoEmpleoDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApiBancoEmpleoDbContext>();
            var connStr = ConfigurationHelper.GetCurrentSettings("ConnectionStrings:DefaultConnection");
            optionsBuilder.UseSqlServer(connStr);
            return new ApiBancoEmpleoDbContext(optionsBuilder.Options);
        }
    }


}
