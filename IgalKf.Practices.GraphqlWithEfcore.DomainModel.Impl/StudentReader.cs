namespace IgalKf.Practices.GraphqlWithEfcore.DomainModel.Impl;

using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using IgalKf.Practices.GraphqlWithEfcore.DomainModel;
using IgalKf.Practices.GraphqlWithEfcore.DomainModel.Cqrs;
using Igalkf.Practices.GraphqlWithEfcore.EntityModel;
using Igalkf.Practices.GraphqlWithEfcore.PersistenceModel.EntityFramework;
using MediatR;

/// <summary>
/// InitialClass.
/// </summary>
public class StudentReader
    : IRequestHandler<StudetQuery, IQueryable<StudentDto>>
{
    private readonly SchoolContext schoolContext;

    /// <summary>
    /// Initializes a new instance of the <see cref="StudentReader"/> class.
    /// </summary>
    /// <param name="schoolContext">School database context.</param>
    public StudentReader(SchoolContext schoolContext)
    {
        this.schoolContext = schoolContext;
    }

    /// <inheritdoc/>
    public Task<IQueryable<StudentDto>> Handle(StudetQuery request, CancellationToken cancellationToken)
    {
        MapperConfiguration mapperConfiguration =
            new(m => m.CreateProjection<Student, StudentDto>()
            .ForMember(d => d.EnrollmentCount, a => a.MapFrom(s => s.Enrollments.Count)));

        IQueryable<StudentDto> students = this.schoolContext.Students.ProjectTo<StudentDto>(mapperConfiguration);
        return Task.FromResult(students);
    }
}
