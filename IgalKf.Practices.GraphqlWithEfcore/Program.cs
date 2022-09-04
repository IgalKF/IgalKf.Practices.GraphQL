using Igalkf.Practices.GraphqlWithEfcore.ApplicationModel;

var builder = WebApplication.CreateBuilder(args);

builder.Services.ConfigureServices();

WebApplication app = builder.Build();

app.ConfigureApplication();

app.Run();
