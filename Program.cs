var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
//app.UseAuthentication();
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

//app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Araba}/{action=Index}/{id?}");


app.MapControllerRoute(
 name: "erolyolu",
 pattern: "Erol/{id?}",
 defaults: new { controller = "Home", action = "Erol" });

 app.MapControllerRoute(
    name:"haber-yolu",
    pattern:"Haber/{id:int}",
    defaults:new {controller="Haberler",action="Detay"} );
app.Run();
