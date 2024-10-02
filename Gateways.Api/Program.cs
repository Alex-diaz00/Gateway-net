using Gateways.Common.Filters;
using Gateways.Common.Helpers;
using Gateways.Business.Bootstrapper;
using Gateways.Data.Implementations;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddAutoMapper(typeof(Program));

builder.Services.AddControllers(options =>
{
    options.Filters.Add<HttpResponseExceptionFilter>();
});

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(options =>
{
    options.DocumentFilter<SwaggerDocumentFilter>();
});

builder.Services.ConfigureSwaggerGen(options =>
{
    options.CustomSchemaIds(GetSchema.GetSchemaId);
});

builder.Services.Boot(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

IServiceScope scope = app.Services.CreateScope();

ObjectContext db = scope.ServiceProvider.GetRequiredService<ObjectContext>();

db.Database.EnsureCreated();

DatabaseInitializer.InitializeDatabase(db);


app.Run();


public partial class Program { }
