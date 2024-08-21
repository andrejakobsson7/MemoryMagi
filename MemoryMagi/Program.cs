using MemoryMagi.Database;
using MemoryMagi.Models;
using MemoryMagi.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAuthorization();

// Lägg till Identity för user o roles
builder.Services.AddIdentity<ApplicationUser, IdentityRole>(options =>
{
    options.Password.RequireDigit = true;
    options.Password.RequireLowercase = true;
    options.Password.RequireUppercase = true;
    options.Password.RequireNonAlphanumeric = true;
    options.Password.RequiredLength = 6;
})
    .AddEntityFrameworkStores<AppDbContext>()
    .AddDefaultTokenProviders()
    .AddSignInManager<SignInManager<ApplicationUser>>()
    .AddUserManager<UserManager<ApplicationUser>>();




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


builder.Services.AddScoped<ItemRepository>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<IUserItemRepository, UserItemRepository>();

var app = builder.Build();

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


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();
// För att kommma åt bilder:
app.UseStaticFiles();
app.UseCors("AllowAll");
app.UseAuthorization();
app.MapControllers();
app.Run();



