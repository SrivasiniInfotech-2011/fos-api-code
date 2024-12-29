using FOS.Infrastructure.Commands;
using FOS.Infrastructure.Queries;
using FOS.Infrastructure.Services.FileServer;
using FOS.Models.Configurations;
using FOS.Models.Constants;
using FOS.Models.Entities;
using FOS.Models.Requests;
using FOS.Repository.Implementors;
using FOS.Repository.Interfaces;
using FOS.Users.Api;
using FOS.Users.Api.Middleware;
using IdentityServer4.AccessTokenValidation;
using MediatR;
using Microsoft.OpenApi.Models;
using Serilog;
using System.Collections.Generic;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddCors();
builder.Services.AddControllers();
var configuration = builder.Configuration
                         .AddJsonFile($"appsettings.json")
                         .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json")
                         .Build();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "FOS.USER.API", Version = "v1" });
});
builder.Services.AddAuthentication(IdentityServerAuthenticationDefaults.AuthenticationScheme)
             .AddIdentityServerAuthentication(options =>
             {
                 options.Authority = configuration["IdentityServerUrl"];
                 options.ApiName = Constants.ApiResource.UserApi;
                 options.ApiSecret = Constants.ApiResource.ApiResourceSecret;
                 options.RequireHttpsMetadata = false;
             });
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAngularApp",
        builder => builder.WithOrigins(configuration["AllowCORSUrls"]!.Split(','))
                          .AllowAnyMethod()
                          .AllowAnyHeader()
                          .AllowCredentials());
});

//TODO : Make changes when necessary. 
//services.AddCors(corsOptions =>
//{
//    corsOptions.AddPolicy(DefaultCorsPolicy,
//        corsBuilder =>
//        {
//            corsBuilder.WithOrigins(ApiConfiguration?.Global.Cors?.AllowedOrigins ?? throw new InvalidOperationException());
//            corsBuilder.AllowAnyHeader();
//            corsBuilder.WithMethods(ApiConfiguration.Global.Cors?.AllowedMethods!);
//        });
//});
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblyContaining<FOS.Users.Api.Startup>());
builder.Services.AddAutoMapper(Assembly.GetAssembly(typeof(FOS.Models.Constants.Startup)));
builder.Services.AddTransient<IMediator, Mediator>();
builder.Services.AddTransient<IUserRepository>(s => new UserRepository(configuration.GetConnectionString("FOSConnectionString")!));
builder.Services.AddTransient<IRequestHandler<GetUserByUserNameAndPassword.Query, User?>, GetUserByUserNameAndPassword.Handler>();
builder.Services.AddTransient<IRequestHandler<GetUserMenusByUserId.Query, List<UserMenu>>, GetUserMenusByUserId.Handler>();
builder.Services.AddTransient<IFileServerService, FileServerService>(s => new FileServerService(new FileServerConfiguration { CmsFilePath = configuration["CmsPath"], CmsUrl = configuration["CmsUrl"] }, s.GetService<ILogger<FileServerService>>()!));
builder.Services.AddTransient<IUsermanagementRepository>(s => new UserManagementRepository(configuration.GetConnectionString("FOSConnectionString")!));
builder.Services.AddTransient<IUsermanagementRepository>(s => new UserManagementRepository(configuration.GetConnectionString("FOSConnectionString")!));
builder.Services.AddTransient<IRequestHandler<UserLevelLookup.Query, List<Lookup>>, UserLevelLookup.Handler>();
builder.Services.AddTransient<IRequestHandler<GetUserDesignationlevelLookups.Query, List<Lookup>>, GetUserDesignationlevelLookups.Handler>();
builder.Services.AddTransient<IRequestHandler<ViewUserDetails.Query, GetInsertUserDetailsModel>, ViewUserDetails.Handler>();
//builder.Services.AddTransient<IRequestHandler<GetUsertranslanderInfrastructure.Query, GetUserTranslanderModel>, GetUsertranslanderInfrastructure.Handler>();
builder.Services.AddTransient<IRequestHandler<GetUsertranslanderInfrastructure.Query, List<GetUserTranslanderModel>>, GetUsertranslanderInfrastructure.Handler>();
builder.Services.AddTransient<IRequestHandler<UserReportinglevel.Query, List<ReportingLevel>>, UserReportinglevel.Handler>();
builder.Services.AddTransient<IRequestHandler<InsertUserDetails.Command, int>, InsertUserDetails.Handler>();
builder.Host.UseSerilog((context, configuration) =>
    configuration.ReadFrom.Configuration(context.Configuration));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("AllowAngularApp");
app.UseMiddleware<FOSExceptionMiddleware>();
app.UseSerilogRequestLogging();
app.UseHttpsRedirection();
app.UseAuthorization();

app.MapControllers();

app.Run();

