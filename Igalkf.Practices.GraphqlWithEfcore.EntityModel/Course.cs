namespace Igalkf.Practices.GraphqlWithEfcore.EntityModel;

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

/// <summary>
/// Course entity.
/// </summary>
public class Course
{
    /// <summary>
    /// Gets or sets course's identifier.
    /// </summary>
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int CourseId { get; set; }

    /// <summary>
    /// Gets or sets course's title.
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    /// Gets or sets courses credits.
    /// </summary>
    public int Credits { get; set; }

    /// <summary>
    /// Gets or sets course's enrollnebts collection.
    /// </summary>
    public virtual ICollection<Enrollment> Enrollments { get; set; }
}
