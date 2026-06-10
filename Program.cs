using UserManagementAPI.Services;
using UserManagementAPI.Middleware;

var builder = WebApplication.CreateBuilder(args);

// Register services
builder.Services.AddSingleton<UserService>();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Swagger
app.UseSwagger();
app.UseSwaggerUI();

// Middleware pipeline - ORDER MATTERS
app.UseMiddleware<ErrorHandlingMiddleware>();
app.UseMiddleware<AuthenticationMiddleware>();
app.UseMiddleware<LoggingMiddleware>();

app.MapControllers();
app.Run();