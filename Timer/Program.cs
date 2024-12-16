using WebApplication1;
using WebApplication1.Services;

var builder = WebApplication.CreateBuilder(args);
var startup = new Startup(builder.Configuration);
// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddControllers();
builder.Services.AddTransient<ICarsService, CarsServiceImpl>(); // Replace CarsService with your actual implementation class
builder.Services.AddHostedService<DailyTaskService>();

var app = builder.Build();
startup.Configure(app, app.Environment);

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.Run();