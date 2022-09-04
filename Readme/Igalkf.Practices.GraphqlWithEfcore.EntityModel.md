<a name='assembly'></a>
# Igalkf.Practices.GraphqlWithEfcore.EntityModel

## Contents

- [Course](#T-Igalkf-Practices-GraphqlWithEfcore-EntityModel-Course 'Igalkf.Practices.GraphqlWithEfcore.EntityModel.Course')
  - [CourseId](#P-Igalkf-Practices-GraphqlWithEfcore-EntityModel-Course-CourseId 'Igalkf.Practices.GraphqlWithEfcore.EntityModel.Course.CourseId')
  - [Credits](#P-Igalkf-Practices-GraphqlWithEfcore-EntityModel-Course-Credits 'Igalkf.Practices.GraphqlWithEfcore.EntityModel.Course.Credits')
  - [Enrollments](#P-Igalkf-Practices-GraphqlWithEfcore-EntityModel-Course-Enrollments 'Igalkf.Practices.GraphqlWithEfcore.EntityModel.Course.Enrollments')
  - [Title](#P-Igalkf-Practices-GraphqlWithEfcore-EntityModel-Course-Title 'Igalkf.Practices.GraphqlWithEfcore.EntityModel.Course.Title')
- [Enrollment](#T-Igalkf-Practices-GraphqlWithEfcore-EntityModel-Enrollment 'Igalkf.Practices.GraphqlWithEfcore.EntityModel.Enrollment')
  - [Course](#P-Igalkf-Practices-GraphqlWithEfcore-EntityModel-Enrollment-Course 'Igalkf.Practices.GraphqlWithEfcore.EntityModel.Enrollment.Course')
  - [CourseId](#P-Igalkf-Practices-GraphqlWithEfcore-EntityModel-Enrollment-CourseId 'Igalkf.Practices.GraphqlWithEfcore.EntityModel.Enrollment.CourseId')
  - [EnrollmentId](#P-Igalkf-Practices-GraphqlWithEfcore-EntityModel-Enrollment-EnrollmentId 'Igalkf.Practices.GraphqlWithEfcore.EntityModel.Enrollment.EnrollmentId')
  - [Grade](#P-Igalkf-Practices-GraphqlWithEfcore-EntityModel-Enrollment-Grade 'Igalkf.Practices.GraphqlWithEfcore.EntityModel.Enrollment.Grade')
  - [Student](#P-Igalkf-Practices-GraphqlWithEfcore-EntityModel-Enrollment-Student 'Igalkf.Practices.GraphqlWithEfcore.EntityModel.Enrollment.Student')
  - [StudentId](#P-Igalkf-Practices-GraphqlWithEfcore-EntityModel-Enrollment-StudentId 'Igalkf.Practices.GraphqlWithEfcore.EntityModel.Enrollment.StudentId')
- [Grade](#T-Igalkf-Practices-GraphqlWithEfcore-EntityModel-Grade 'Igalkf.Practices.GraphqlWithEfcore.EntityModel.Grade')
  - [A](#F-Igalkf-Practices-GraphqlWithEfcore-EntityModel-Grade-A 'Igalkf.Practices.GraphqlWithEfcore.EntityModel.Grade.A')
  - [B](#F-Igalkf-Practices-GraphqlWithEfcore-EntityModel-Grade-B 'Igalkf.Practices.GraphqlWithEfcore.EntityModel.Grade.B')
  - [C](#F-Igalkf-Practices-GraphqlWithEfcore-EntityModel-Grade-C 'Igalkf.Practices.GraphqlWithEfcore.EntityModel.Grade.C')
  - [D](#F-Igalkf-Practices-GraphqlWithEfcore-EntityModel-Grade-D 'Igalkf.Practices.GraphqlWithEfcore.EntityModel.Grade.D')
  - [F](#F-Igalkf-Practices-GraphqlWithEfcore-EntityModel-Grade-F 'Igalkf.Practices.GraphqlWithEfcore.EntityModel.Grade.F')
- [Student](#T-Igalkf-Practices-GraphqlWithEfcore-EntityModel-Student 'Igalkf.Practices.GraphqlWithEfcore.EntityModel.Student')
  - [EnrollmentDate](#P-Igalkf-Practices-GraphqlWithEfcore-EntityModel-Student-EnrollmentDate 'Igalkf.Practices.GraphqlWithEfcore.EntityModel.Student.EnrollmentDate')
  - [Enrollments](#P-Igalkf-Practices-GraphqlWithEfcore-EntityModel-Student-Enrollments 'Igalkf.Practices.GraphqlWithEfcore.EntityModel.Student.Enrollments')
  - [FirstMidName](#P-Igalkf-Practices-GraphqlWithEfcore-EntityModel-Student-FirstMidName 'Igalkf.Practices.GraphqlWithEfcore.EntityModel.Student.FirstMidName')
  - [Id](#P-Igalkf-Practices-GraphqlWithEfcore-EntityModel-Student-Id 'Igalkf.Practices.GraphqlWithEfcore.EntityModel.Student.Id')
  - [LastName](#P-Igalkf-Practices-GraphqlWithEfcore-EntityModel-Student-LastName 'Igalkf.Practices.GraphqlWithEfcore.EntityModel.Student.LastName')

<a name='T-Igalkf-Practices-GraphqlWithEfcore-EntityModel-Course'></a>
## Course `type`

##### Namespace

Igalkf.Practices.GraphqlWithEfcore.EntityModel

##### Summary

Course entity.

<a name='P-Igalkf-Practices-GraphqlWithEfcore-EntityModel-Course-CourseId'></a>
### CourseId `property`

##### Summary

Gets or sets course's identifier.

<a name='P-Igalkf-Practices-GraphqlWithEfcore-EntityModel-Course-Credits'></a>
### Credits `property`

##### Summary

Gets or sets courses credits.

<a name='P-Igalkf-Practices-GraphqlWithEfcore-EntityModel-Course-Enrollments'></a>
### Enrollments `property`

##### Summary

Gets or sets course's enrollnebts collection.

<a name='P-Igalkf-Practices-GraphqlWithEfcore-EntityModel-Course-Title'></a>
### Title `property`

##### Summary

Gets or sets course's title.

<a name='T-Igalkf-Practices-GraphqlWithEfcore-EntityModel-Enrollment'></a>
## Enrollment `type`

##### Namespace

Igalkf.Practices.GraphqlWithEfcore.EntityModel

##### Summary

Enrollment entity.

<a name='P-Igalkf-Practices-GraphqlWithEfcore-EntityModel-Enrollment-Course'></a>
### Course `property`

##### Summary

Gets or sets enrollment's course.

<a name='P-Igalkf-Practices-GraphqlWithEfcore-EntityModel-Enrollment-CourseId'></a>
### CourseId `property`

##### Summary

Gets or sets enrollment's course identifier.

<a name='P-Igalkf-Practices-GraphqlWithEfcore-EntityModel-Enrollment-EnrollmentId'></a>
### EnrollmentId `property`

##### Summary

Gets or sets enrollment identifier.

<a name='P-Igalkf-Practices-GraphqlWithEfcore-EntityModel-Enrollment-Grade'></a>
### Grade `property`

##### Summary

Gets or sets enrollment's grade.

<a name='P-Igalkf-Practices-GraphqlWithEfcore-EntityModel-Enrollment-Student'></a>
### Student `property`

##### Summary

Gets or sets the student who has enrolled.

<a name='P-Igalkf-Practices-GraphqlWithEfcore-EntityModel-Enrollment-StudentId'></a>
### StudentId `property`

##### Summary

Gets or sets student's identifier the enrollment belongs to.

<a name='T-Igalkf-Practices-GraphqlWithEfcore-EntityModel-Grade'></a>
## Grade `type`

##### Namespace

Igalkf.Practices.GraphqlWithEfcore.EntityModel

##### Summary

School grades for student.

<a name='F-Igalkf-Practices-GraphqlWithEfcore-EntityModel-Grade-A'></a>
### A `constants`

##### Summary

First grade.

<a name='F-Igalkf-Practices-GraphqlWithEfcore-EntityModel-Grade-B'></a>
### B `constants`

##### Summary

Second grade.

<a name='F-Igalkf-Practices-GraphqlWithEfcore-EntityModel-Grade-C'></a>
### C `constants`

##### Summary

Third grade.

<a name='F-Igalkf-Practices-GraphqlWithEfcore-EntityModel-Grade-D'></a>
### D `constants`

##### Summary

Forth grade.

<a name='F-Igalkf-Practices-GraphqlWithEfcore-EntityModel-Grade-F'></a>
### F `constants`

##### Summary

Fifth grade.

<a name='T-Igalkf-Practices-GraphqlWithEfcore-EntityModel-Student'></a>
## Student `type`

##### Namespace

Igalkf.Practices.GraphqlWithEfcore.EntityModel

##### Summary

Student entity.

<a name='P-Igalkf-Practices-GraphqlWithEfcore-EntityModel-Student-EnrollmentDate'></a>
### EnrollmentDate `property`

##### Summary

Gets or sets student's enrollement date.

<a name='P-Igalkf-Practices-GraphqlWithEfcore-EntityModel-Student-Enrollments'></a>
### Enrollments `property`

##### Summary

Gets or sets student's collection of enrollments.

<a name='P-Igalkf-Practices-GraphqlWithEfcore-EntityModel-Student-FirstMidName'></a>
### FirstMidName `property`

##### Summary

Gets or sets student's first name and middle name if exists.

<a name='P-Igalkf-Practices-GraphqlWithEfcore-EntityModel-Student-Id'></a>
### Id `property`

##### Summary

Gets or sets studebt's identifier.

<a name='P-Igalkf-Practices-GraphqlWithEfcore-EntityModel-Student-LastName'></a>
### LastName `property`

##### Summary

Gets or sets student's last name.
