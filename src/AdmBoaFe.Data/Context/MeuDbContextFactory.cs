using AdmBoaFe.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

public class MeuDbContextFactory : IDesignTimeDbContextFactory<MeuDbContext>
{
    public MeuDbContext CreateDbContext(string[] args)
    {
        var connectionString = "Server=localhost:8080;Initial Catalog=AdmBoaFe;User Id=Taesa;Password=Taesa;Encrypt=False;TrustServerCertificate=True";

        var optionsBuilder = new DbContextOptionsBuilder<MeuDbContext>();
        optionsBuilder.UseSqlServer(connectionString);

        return new MeuDbContext(optionsBuilder.Options);
    }
}
