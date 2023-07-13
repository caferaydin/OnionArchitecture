using FluentValidation.AspNetCore;
using xProject.Application.Validators.Products;
using xProject.Infrastructure.Filters;
using xProject.Persistence.DependencyResolvers;

var builder = WebApplication.CreateBuilder(args);


// Added - start
builder.Services.AddPresentationServices(); // service extension
builder.Services.AddCors(options => options.AddDefaultPolicy(policy =>
    //policy.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin()
    policy.WithOrigins("http://localhost:4200", "https://localhost:4200")
    .AllowAnyHeader().AllowAnyMethod()
    )) ;


// Validation
builder.Services.AddControllers( option=> option.Filters.Add<ValidationFilter>())
    .AddFluentValidation(configuration => configuration.RegisterValidatorsFromAssemblyContaining<CreateProductValidator>());

// Added - End

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors(); // add cors policy

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
