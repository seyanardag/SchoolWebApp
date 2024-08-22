
using EntityLayer.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using WebUI.CustomServices.Abstract;
using WebUI.CustomServices.Concrete;
using DataAccessLayer.Context;
using WebUI.SeedIdentityDb;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.



builder.Services.AddDbContext<SchoolDbContext>(); //Identity i�in
builder.Services.AddIdentity<CustomUser, CustomRole>().AddEntityFrameworkStores<SchoolDbContext>();  // Identity  i�in

// B�t��n controller lar i�in kimilik do�rulama politikas�
builder.Services.AddControllersWithViews(options =>
{
    options.Filters.Add(new AuthorizeFilter(new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build()));
});

//Identity cookie lerinin davran��lar� ve g�venlik �zelliklerinin ayarlanmas�
builder.Services.ConfigureApplicationCookie(options =>
{
    options.Cookie.HttpOnly = true;
    options.ExpireTimeSpan = TimeSpan.FromMinutes(10);
    options.AccessDeniedPath = "/Error/ErrorPage/";
    options.LoginPath = "/Login/Index";
});


//FileUploadService in DI Conteyner �na kaydedilmesi
builder.Services.AddScoped<IFileUploadService, FileUploadService>();


//HttpClient istekleri i�in gerekli servisin eklenmesi;
builder.Services.AddHttpClient();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Home/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();  //Authenticaton i�in ekledik

app.UseAuthorization();

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Login}/{action=Index}/{id?}");



//Default admin profilinin database i seedlemesi
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    await SeedData.Initialize(services);
}


app.Run();
