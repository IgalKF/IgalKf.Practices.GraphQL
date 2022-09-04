namespace IgalKf.Practices.GraphqlWithEfcore.ServiceModel.Graphql;

using HotChocolate;
using HotChocolate.Types;
using IgalKf.Practices.GraphqlWithEfcore.DomainModel;
using IgalKf.Practices.GraphqlWithEfcore.DomainModel.Cqrs;
using Igalkf.Practices.GraphqlWithEfcore.PersistenceModel.EntityFramework;
using MediatR;

/// <summary>
/// Students' query.
/// </summary>
public class Query
{
    /// <summary>
    /// Gets all students.
    /// </summary>
    /// <param name="mediator"><see cref="SchoolContext"/> instance.</param>
    /// <returns>Queried students by demand.</returns>
    [Serial]
    [UseProjection]
    [UseFiltering]
    [UseSorting]
    public async Task<IQueryable<StudentDto>> GetStudents([Service] IMediator mediator) => await mediator.Send(new StudetQuery());
}