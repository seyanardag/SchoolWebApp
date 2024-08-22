

using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Context;
using Microsoft.EntityFrameworkCore;
using System.Reflection;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


builder.Services.AddCors(opt =>
{
    opt.AddPolicy("CorsPolicy", builder =>
    {
        builder.AllowAnyHeader()
                .AllowAnyMethod()
                .SetIsOriginAllowed((host) => true)
                .AllowCredentials();

    });
});




builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//DbContext in Dependency Injection Conteyner �na eklenmesi;
builder.Services.AddDbContext<SchoolDbContext>( options => options.UseSqlServer(builder.Configuration.GetConnectionString("SchoolDbConnection")) );

//AutoMapper �n servise eklenmesi;
builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());


builder.Services.AddScoped<IStudentService, StudentManager>();
builder.Services.AddScoped<IStudentDal, EfStudentDal>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

//Yukar�da tan�mlanan Cors policy nin kullan�m�
app.UseCors("CorsPolicy");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
