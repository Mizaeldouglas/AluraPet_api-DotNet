using AluraPet_api.Models;
using Microsoft.EntityFrameworkCore;

namespace AluraPet_api.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Tutor> Tutors { get; set; }
}