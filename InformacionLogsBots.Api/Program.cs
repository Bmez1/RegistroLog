using InformacionLogsBots.Api.Middleware;
using InformacionLogsBots.Application;
using InformacionLogsBots.DataAccess;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services
    .AddApplication()
    .AddDataAccess();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UsePathBase(new PathString("/DevLogs"));
    app.UseSwagger();
    app.UseSwaggerUI();
}
else
{
    app.UsePathBase(new PathString("/Logs"));
}


app.UseMiddleware<ExceptionMiddleware>();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
