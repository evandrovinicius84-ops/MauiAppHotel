var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.MauiAppHotel>("mauiapphotel");

builder.Build().Run();
