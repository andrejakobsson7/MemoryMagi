using MemoryMagi.Database;
using MemoryMagi.Models;
using MemoryMagi.Repositories;
using MemoryMagi.Repositories._2._0;
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

// 
builder.Services.AddIdentityApiEndpoints<IdentityUser>()
    .AddEntityFrameworkStores<AppDbContext>();

// Lägg till Identity för user o roles
//builder.Services.AddIdentity<IdentityUser, IdentityRole>(options => { })
//    .AddEntityFrameworkStores<AppDbContext>()
//    .AddDefaultTokenProviders();
//builder.Services.AddIdentity<ApplicationUser, IdentityRole>(options =>
//{
//options.Password.RequireDigit = true;
//options.Password.RequireLowercase = true;
//options.Password.RequireUppercase = true;
//options.Password.RequireNonAlphanumeric = true;
//options.Password.RequiredLength = 6;
//})
//.AddEntityFrameworkStores<AppDbContext>()
//.AddDefaultTokenProviders()
//.AddSignInManager<SignInManager<ApplicationUser>>()
// .AddUserManager<UserManager<ApplicationUser>>();

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


// Förbered för admin
builder.Services.AddIdentityCore<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = false)
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<AppDbContext>()
    // Lägger till signinmanager och usermanager
    .AddSignInManager<SignInManager<ApplicationUser>>()
    .AddUserManager<UserManager<ApplicationUser>>()
    .AddDefaultTokenProviders();

builder.Services.AddScoped<IGameModelRepository, GameModelRepository>();
builder.Services.AddScoped<ICategoryModelRepository, CategoryModelRepository>();
builder.Services.AddScoped<ItemRepository>();
builder.Services.AddScoped(typeof(GenericRepository<>));

var app = builder.Build();

app.UseCors("AllowAll");

app.UseAuthorization();


// Seeda roller / admin
using (var scope = app.Services.CreateScope())
{
    // Skapa roller och användare
    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<AppDbContext>();
    var signInManager = services.GetRequiredService<SignInManager<ApplicationUser>>();
    var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();
    var userManager = services.GetRequiredService<UserManager<ApplicationUser>>();

    // Kolla om det finns en databas
    context.Database.Migrate();
    //Kommentar från André: Denna failar om det redan finns data i databasen med ID-nummer som vi försöker seeda in. 

    ApplicationUser newAdmin = new()
    {
        UserName = "Admin",
        Email = "admin@magicmagi.com",
        EmailConfirmed = true
    };

    var admin = signInManager.UserManager.FindByEmailAsync(newAdmin.Email)
       // Kör Metoden synkront!Viktigt! 
       .GetAwaiter().GetResult();
    if (admin == null)
    {
        signInManager.UserManager.CreateAsync(newAdmin, "PasswordAdmin1!")
           .GetAwaiter().GetResult();

        admin = newAdmin;

        // Kolla om adminrollen existerar
        bool adminRoleExists = roleManager.RoleExistsAsync("Admin")
            // Kör metoden Synkront! Viktigt!
            .GetAwaiter().GetResult();
        if (!adminRoleExists)
        {
            // Skapa adminrollen
            IdentityRole adminRole = new()
            {
                Name = "Admin",
            };

            roleManager.CreateAsync(adminRole)
            // Kör metoden Synkront! Viktigt!
            .GetAwaiter().GetResult();
        }
        //Tilldela adminrollen
        signInManager.UserManager.AddToRoleAsync(admin, "Admin")
       // Kör metoden Synkront! Viktigt!
       .GetAwaiter().GetResult();
        // hej
    }
}

// Lägg till denna
app.UseCors("AllowAll");

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapIdentityApi<IdentityUser>();

app.UseHttpsRedirection();
// För att kommma åt bilder:
app.UseStaticFiles();

//Endpoint for logging out
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

app.MapControllers();





app.Run();



