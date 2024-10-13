var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.FS_ApiService>("apiservice");

builder.AddProject<Projects.FS_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService);

builder.Build().Run();
