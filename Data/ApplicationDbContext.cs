using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace Hridesh_rai.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }
    public DbSet<Student> Students { get; set; }

}