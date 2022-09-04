<a name='assembly'></a>
# Igalkf.Practices.GraphqlWithEfcore.PersistenceModel.EntityFramework

## Contents

- [SchoolContext](#T-Igalkf-Practices-GraphqlWithEfcore-PersistenceModel-EntityFramework-SchoolContext 'Igalkf.Practices.GraphqlWithEfcore.PersistenceModel.EntityFramework.SchoolContext')
  - [#ctor(options)](#M-Igalkf-Practices-GraphqlWithEfcore-PersistenceModel-EntityFramework-SchoolContext-#ctor-Microsoft-EntityFrameworkCore-DbContextOptions{Igalkf-Practices-GraphqlWithEfcore-PersistenceModel-EntityFramework-SchoolContext}- 'Igalkf.Practices.GraphqlWithEfcore.PersistenceModel.EntityFramework.SchoolContext.#ctor(Microsoft.EntityFrameworkCore.DbContextOptions{Igalkf.Practices.GraphqlWithEfcore.PersistenceModel.EntityFramework.SchoolContext})')
  - [Courses](#P-Igalkf-Practices-GraphqlWithEfcore-PersistenceModel-EntityFramework-SchoolContext-Courses 'Igalkf.Practices.GraphqlWithEfcore.PersistenceModel.EntityFramework.SchoolContext.Courses')
  - [Enrollments](#P-Igalkf-Practices-GraphqlWithEfcore-PersistenceModel-EntityFramework-SchoolContext-Enrollments 'Igalkf.Practices.GraphqlWithEfcore.PersistenceModel.EntityFramework.SchoolContext.Enrollments')
  - [Students](#P-Igalkf-Practices-GraphqlWithEfcore-PersistenceModel-EntityFramework-SchoolContext-Students 'Igalkf.Practices.GraphqlWithEfcore.PersistenceModel.EntityFramework.SchoolContext.Students')
  - [OnConfiguring()](#M-Igalkf-Practices-GraphqlWithEfcore-PersistenceModel-EntityFramework-SchoolContext-OnConfiguring-Microsoft-EntityFrameworkCore-DbContextOptionsBuilder- 'Igalkf.Practices.GraphqlWithEfcore.PersistenceModel.EntityFramework.SchoolContext.OnConfiguring(Microsoft.EntityFrameworkCore.DbContextOptionsBuilder)')
  - [OnModelCreating()](#M-Igalkf-Practices-GraphqlWithEfcore-PersistenceModel-EntityFramework-SchoolContext-OnModelCreating-Microsoft-EntityFrameworkCore-ModelBuilder- 'Igalkf.Practices.GraphqlWithEfcore.PersistenceModel.EntityFramework.SchoolContext.OnModelCreating(Microsoft.EntityFrameworkCore.ModelBuilder)')

<a name='T-Igalkf-Practices-GraphqlWithEfcore-PersistenceModel-EntityFramework-SchoolContext'></a>
## SchoolContext `type`

##### Namespace

Igalkf.Practices.GraphqlWithEfcore.PersistenceModel.EntityFramework

##### Summary

School database context.

<a name='M-Igalkf-Practices-GraphqlWithEfcore-PersistenceModel-EntityFramework-SchoolContext-#ctor-Microsoft-EntityFrameworkCore-DbContextOptions{Igalkf-Practices-GraphqlWithEfcore-PersistenceModel-EntityFramework-SchoolContext}-'></a>
### #ctor(options) `constructor`

##### Summary

Initializes a new instance of the [SchoolContext](#T-Igalkf-Practices-GraphqlWithEfcore-PersistenceModel-EntityFramework-SchoolContext 'Igalkf.Practices.GraphqlWithEfcore.PersistenceModel.EntityFramework.SchoolContext') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| options | [Microsoft.EntityFrameworkCore.DbContextOptions{Igalkf.Practices.GraphqlWithEfcore.PersistenceModel.EntityFramework.SchoolContext}](#T-Microsoft-EntityFrameworkCore-DbContextOptions{Igalkf-Practices-GraphqlWithEfcore-PersistenceModel-EntityFramework-SchoolContext} 'Microsoft.EntityFrameworkCore.DbContextOptions{Igalkf.Practices.GraphqlWithEfcore.PersistenceModel.EntityFramework.SchoolContext}') | Database context options. |

<a name='P-Igalkf-Practices-GraphqlWithEfcore-PersistenceModel-EntityFramework-SchoolContext-Courses'></a>
### Courses `property`

##### Summary

Gets or sets course's dbset.

<a name='P-Igalkf-Practices-GraphqlWithEfcore-PersistenceModel-EntityFramework-SchoolContext-Enrollments'></a>
### Enrollments `property`

##### Summary

Gets or sets enrollment's dbset.

<a name='P-Igalkf-Practices-GraphqlWithEfcore-PersistenceModel-EntityFramework-SchoolContext-Students'></a>
### Students `property`

##### Summary

Gets or sets student's dbset.

<a name='M-Igalkf-Practices-GraphqlWithEfcore-PersistenceModel-EntityFramework-SchoolContext-OnConfiguring-Microsoft-EntityFrameworkCore-DbContextOptionsBuilder-'></a>
### OnConfiguring() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Igalkf-Practices-GraphqlWithEfcore-PersistenceModel-EntityFramework-SchoolContext-OnModelCreating-Microsoft-EntityFrameworkCore-ModelBuilder-'></a>
### OnModelCreating() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.
