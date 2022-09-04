namespace IgalKf.Practices.GraphqlWithEfcore.DomainModel;

using Igalkf.Practices.GraphqlWithEfcore.EntityModel;

/// <summary>
/// Student entity.
/// </summary>
public class StudentDto
{
    /// <summary>
    /// Gets or sets studebt's identifier.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets student's last name.
    /// </summary>
    public string LastName { get; set; }

    /// <summary>
    /// Gets or sets student's first name and middle name if exists.
    /// </summary>
    public string FirstMidName { get; set; }

    /// <summary>
    /// Gets or sets student's enrollement date.
    /// </summary>
    public DateTime EnrollmentDate { get; set; }

    /// <summary>
    /// Gets or sets student's enrollement date.
    /// </summary>
    public int EnrollmentCount { get; set; }

    /// <summary>
    /// Gets or sets student's collection of enrollments.
    /// </summary>
    public virtual ICollection<Enrollment> Enrollments { get; set; }
}
