using xProject.Persistence.DependencyResolvers;

var builder = WebApplication.CreateBuilder(args);


// Added - start
builder.Services.AddPresentationServices(); // service extension
builder.Services.AddCors(options => options.AddDefaultPolicy(policy =>
    //policy.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin()
    policy.WithOrigins("http://localhost:4200", "https://localhost:4200")
    .AllowAnyHeader().AllowAnyMethod()
    )) ;

// Added - End

builder.Services.AddControllers();

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
