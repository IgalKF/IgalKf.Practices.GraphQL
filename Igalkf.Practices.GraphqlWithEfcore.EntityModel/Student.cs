namespace Igalkf.Practices.GraphqlWithEfcore.EntityModel;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

/// <summary>
/// Student entity.
/// </summary>
public class Student
{
    /// <summary>
    /// Gets or sets studebt's identifier.
    /// </summary>
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
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
    /// Gets or sets student's collection of enrollments.
    /// </summary>
    public virtual ICollection<Enrollment> Enrollments { get; set; }
}
