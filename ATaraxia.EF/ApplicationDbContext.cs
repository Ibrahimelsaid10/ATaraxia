namespace ATaraxia.EF;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder builder)
    {

        builder.Entity<Device>()
            .HasOne(e => e.ApplicationUser)
            .WithMany()
            .HasForeignKey(e => e.ApplicationUserId);

        builder.Entity<Question>()
            .HasOne(e => e.ApplicationUser)
            .WithMany()
            .HasForeignKey(e => e.ApplicationUserId);

        builder.Entity<ApplicationUser>()
            .HasOne(e => e.Template)
            .WithMany()
            .HasForeignKey(e => e.TemplateId);

        base.OnModelCreating(builder);
    }

    public virtual DbSet<Template>? Temblates { get; set; }
    public virtual DbSet<ApplicationUser>? ApplicationUsers { get; set; }
    public virtual DbSet<Device>? Devices { get; set; }
    public virtual DbSet<Question>? Questions { get; set; }
}
