namespace Igalkf.Practices.GraphqlWithEfcore.ApplicationModel;

using IgalKf.Practices.GraphqlWithEfcore.DomainModel.Impl;
using Igalkf.Practices.GraphqlWithEfcore.EntityModel;
using Igalkf.Practices.GraphqlWithEfcore.PersistenceModel.EntityFramework;
using IgalKf.Practices.GraphqlWithEfcore.ServiceModel.Graphql;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

/// <summary>
/// Practices extensions.
/// </summary>
public static class PracticesExtensions
{
    /// <summary>
    /// Configure dependency injection services.
    /// </summary>
    /// <param name="services"><see cref="IServiceCollection"/> instance.</param>
    public static void ConfigureServices(this IServiceCollection services)
    {
        services.AddDbContext<SchoolContext>(options =>
        {
            options.EnableSensitiveDataLogging();
        });

        services.AddMediatR(typeof(StudentReader));

        services.AddGraphQLServer()
            .AddQueryType<Query>()
             .AddProjections()
             .AddFiltering()
             .AddSorting();
    }

    /// <summary>
    /// Configure application services.
    /// </summary>
    /// <param name="app"><see cref="WebApplication"/> instance.</param>
    public static void ConfigureApplication(this WebApplication app)
    {
        InitializeDatabase(app);

        if (app.Environment.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }
        else
        {
            app.UseExceptionHandler("/Error");
            app.UseHsts();
        }

        app.MapGraphQL();

        app.UseRouting();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapGet("/", async context =>
            {
                await context.Response.WriteAsync("Hello World!");
            });
        });

        app.UseHttpsRedirection();
        app.UseRouting();
    }

    private static void InitializeDatabase(IApplicationBuilder app)
    {
        using var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope();

        var context = serviceScope.ServiceProvider.GetRequiredService<SchoolContext>();

        if (context.Database.EnsureCreated())
        {
            var course = new Course { Credits = 10, Title = "Object Oriented Programming 1" };

            context.Enrollments.Add(new Enrollment
            {
                Course = course,
                Student = new Student { FirstMidName = "Rafael", LastName = "Foo", EnrollmentDate = DateTime.UtcNow },
            });

            context.Enrollments.Add(new Enrollment
            {
                Course = course,
                Student = new Student { FirstMidName = "Pascal", LastName = "Bar", EnrollmentDate = DateTime.UtcNow },
            });

            context.Students.Add(new Student
            {
                FirstMidName = "Michael",
                LastName = "Baz",
                EnrollmentDate = DateTime.UtcNow,
                Enrollments = new List<Enrollment>()
                {
                    new() { Course = course, },
                    new() { Course = new Course { Credits = 10, Title = "Object Oriented Programming 2" }, },
                },
            });

            context.SaveChangesAsync();
        }
    }
}