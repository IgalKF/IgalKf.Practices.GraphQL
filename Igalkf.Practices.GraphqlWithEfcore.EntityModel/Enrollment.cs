namespace Igalkf.Practices.GraphqlWithEfcore.EntityModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

/// <summary>
/// Enrollment entity.
/// </summary>
public class Enrollment
{
    /// <summary>
    /// Gets or sets enrollment identifier.
    /// </summary>
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int EnrollmentId { get; set; }

    /// <summary>
    /// Gets or sets enrollment's course identifier.
    /// </summary>
    public int CourseId { get; set; }

    /// <summary>
    /// Gets or sets student's identifier the enrollment belongs to.
    /// </summary>
    public int StudentId { get; set; }

    /// <summary>
    /// Gets or sets enrollment's grade.
    /// </summary>
    public Grade? Grade { get; set; }

    /// <summary>
    /// Gets or sets enrollment's course.
    /// </summary>
    public virtual Course Course { get; set; }

    /// <summary>
    /// Gets or sets the student who has enrolled.
    /// </summary>
    public virtual Student Student { get; set; }
}
