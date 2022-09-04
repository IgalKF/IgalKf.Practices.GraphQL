namespace Igalkf.Practices.GraphqlWithEfcore.PersistenceModel.EntityFramework;

using Igalkf.Practices.GraphqlWithEfcore.EntityModel;
using Microsoft.EntityFrameworkCore;

/// <summary>
/// School database context.
/// </summary>
public class SchoolContext : DbContext
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SchoolContext"/> class.
    /// </summary>
    /// <param name="options">Database context options.</param>
    public SchoolContext(DbContextOptions<SchoolContext> options)
        : base(options)
    {
    }

    /// <summary>
    /// Gets or sets student's dbset.
    /// </summary>
    public DbSet<Student> Students { get; set; }

    /// <summary>
    /// Gets or sets enrollment's dbset.
    /// </summary>
    public DbSet<Enrollment> Enrollments { get; set; }

    /// <summary>
    /// Gets or sets course's dbset.
    /// </summary>
    public DbSet<Course> Courses { get; set; }

    /// <inheritdoc/>
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlite("Data Source=uni.db");
    }

    /// <inheritdoc/>
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Student>()
            .HasMany(t => t.Enrollments)
            .WithOne(t => t.Student)
            .HasForeignKey(t => t.StudentId);

        modelBuilder.Entity<Enrollment>()
            .HasIndex(t => new { t.StudentId, t.CourseId })
            .IsUnique();

        modelBuilder.Entity<Course>()
            .HasMany(t => t.Enrollments)
            .WithOne(t => t.Course)
            .HasForeignKey(t => t.CourseId);
    }
}