using AgenciaHorizonteAberto.ComponentModel;
using Microsoft.EntityFrameworkCore;

namespace AgenciaHorizonteAberto.Data
{


    public class DataContext : DbContext 
{
public DataContext (DbContextOptions<DataContext> options) : base(options)
{
}

public DbSet<Viagem> AgenciaHorizonteAberto {get; set;}

}

}
