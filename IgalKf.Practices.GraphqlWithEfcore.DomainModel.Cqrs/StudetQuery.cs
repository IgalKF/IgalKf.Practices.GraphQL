namespace IgalKf.Practices.GraphqlWithEfcore.DomainModel.Cqrs;

using IgalKf.Practices.GraphqlWithEfcore.DomainModel;
using MediatR;

/// <summary>
/// InitialClass.
/// </summary>
public record StudetQuery() : IRequest<IQueryable<StudentDto>>;