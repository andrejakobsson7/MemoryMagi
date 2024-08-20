using MemoryMagi.Database;
using MemoryMagi.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAuthorization();

builder.Services.AddIdentityApiEndpoints<IdentityUser>()
    .AddEntityFrameworkStores<AppDbContext>();

//Hämta connection string från appsettings.json
var connectionString = builder.Configuration.GetConnectionString("DbConnection");

//Lägg till context i dependency injection container
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", options =>
    {
        options.AllowAnyHeader();
        options.AllowAnyMethod();
        options.AllowAnyOrigin();
    });
});

builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<IUserItemRepository, UserItemRepository>();

var app = builder.Build();

//FREDRIK
// Seeda roller - Valhalla
//using (var scope = app.Services.CreateScope())
//{
//    // Skapa roller och användare
//    var adminManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
//    var userManager = scope.ServiceProvider.GetRequiredService<UserManager<IdentityUser>>();

//    await SeedaAdmin(userManager, adminManager);
//}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapIdentityApi<IdentityUser>();

app.UseAuthorization();

// För att kommma åt bilder:
app.UseStaticFiles();

app.UseCors("AllowAll");

app.MapControllers();

app.MapPost("/logout", async (SignInManager<IdentityUser> signInManager,
    [FromBody] object empty) =>
{
    if (empty != null)
    {
        await signInManager.SignOutAsync();
        return Results.Ok();
    }
    return Results.Unauthorized();
})
.RequireAuthorization();
//Komma åt roller 
//FREDRIK
//app.MapIdentityApi<IdentityUser>();

app.Run();

//FREDRIK
//async Task SeedaAdmin(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
//{
//    // skapa admin
//    string oneAdmin = "Admin";
//    // oneAdmin > 0 

//    var roleExists = await roleManager.RoleExistsAsync(oneAdmin);

//    if (!roleExists)
//    {
//        await roleManager.CreateAsync(new IdentityRole(oneAdmin));
//    }

//    // skapa admin user
//    var adminUser = new IdentityUser
//    {
//        UserName = "admin",
//        Email = "admin@memorymagi.com",
//        EmailConfirmed = true
//    };

//    // Se om admin finns 
//    var adminExists = await userManager.FindByEmailAsync(adminUser.Email);
//    if (adminExists == null)
//    {
//        // Skapa lösenord till admin
//        var result = await userManager.CreateAsync(adminUser, "PasswordAdmin");

//        // Ge admin role
//        await userManager.AddToRoleAsync(adminUser, oneAdmin);
//    }
//}//