<a name='assembly'></a>
# IgalKf.Practices.GraphqlWithEfcore.ServiceModel.Graphql

## Contents

- [Query](#T-IgalKf-Practices-GraphqlWithEfcore-ServiceModel-Graphql-Query 'IgalKf.Practices.GraphqlWithEfcore.ServiceModel.Graphql.Query')
  - [GetStudents(mediator)](#M-IgalKf-Practices-GraphqlWithEfcore-ServiceModel-Graphql-Query-GetStudents-MediatR-IMediator- 'IgalKf.Practices.GraphqlWithEfcore.ServiceModel.Graphql.Query.GetStudents(MediatR.IMediator)')

<a name='T-IgalKf-Practices-GraphqlWithEfcore-ServiceModel-Graphql-Query'></a>
## Query `type`

##### Namespace

IgalKf.Practices.GraphqlWithEfcore.ServiceModel.Graphql

##### Summary

Students' query.

<a name='M-IgalKf-Practices-GraphqlWithEfcore-ServiceModel-Graphql-Query-GetStudents-MediatR-IMediator-'></a>
### GetStudents(mediator) `method`

##### Summary

Gets all students.

##### Returns

Queried students by demand.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| mediator | [MediatR.IMediator](#T-MediatR-IMediator 'MediatR.IMediator') | [SchoolContext](#T-Igalkf-Practices-GraphqlWithEfcore-PersistenceModel-EntityFramework-SchoolContext 'Igalkf.Practices.GraphqlWithEfcore.PersistenceModel.EntityFramework.SchoolContext') instance. |
