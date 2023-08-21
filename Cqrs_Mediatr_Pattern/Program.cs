using Cqrs_Mediatr_Pattern;
using Cqrs_Mediatr_Pattern.Behavior;
using Cqrs_Mediatr_Pattern.Queries;
using MediatR;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddMediatR(typeof(Program));
builder.Services.AddSingleton<FakeDataSource>();
builder.Services.AddSingleton(typeof(IPipelineBehavior<,>), typeof(LoggingBehavior<,>));

//Handle for specific request and response
//builder.Services.AddSingleton(typeof(IPipelineBehavior<GetProductsQuery, IEnumerable<Product>>), typeof(LoggingBehavior<GetProductsQuery, IEnumerable<Product>>));



builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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

app.Run();
