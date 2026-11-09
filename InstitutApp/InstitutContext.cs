using Microsoft.EntityFrameworkCore;

namespace InstitutApp;

public class InstitutContext:DbContext
{
    public InstitutContext(){}
    //Mapegem els DBsets com mapejaven les taules a hibernate
    public DbSet<Professor> Professor { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if(!optionsBuilder.IsConfigured) optionsBuilder.UseSqlite("Data Source=institut.db");
        
    }
}