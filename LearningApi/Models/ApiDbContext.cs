using Microsoft.EntityFrameworkCore;

namespace LearningApi.Models;

public class ApiDbContext : DbContext
{
    public ApiDbContext(DbContextOptions options) : base(options)
    {
        
    }

    public DbSet<Fornecedor> Fornecedores { get; set;}
}
