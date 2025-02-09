using System.Linq;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PetAdoptionManagement.Components.Domain;
using PetAdoptionManagement.Data;

public class UserService
{
    private readonly UserManager<PetAdoptionManagementUser> _userManager;
    private readonly IDbContextFactory<PetAdoptionManagementContext> _dbFactory;
    private readonly RoleManager<IdentityRole> _roleManager;

    public UserService(
        UserManager<PetAdoptionManagementUser> userManager,
        IDbContextFactory<PetAdoptionManagementContext> dbFactory,
        RoleManager<IdentityRole> roleManager)
    {
        _userManager = userManager;
        _dbFactory = dbFactory;
        _roleManager = roleManager;
    }

    public async Task SyncUsersAsync()
    {
        using var dbContext = await _dbFactory.CreateDbContextAsync();

        var existingUserEmails = await dbContext.User.Select(u => u.Email).ToListAsync(); // ✅ Check existing emails

        var identityUsers = await _userManager.Users.ToListAsync();

        foreach (var identityUser in identityUsers)
        {
            if (identityUser == null || existingUserEmails.Contains(identityUser.Email))
                continue; // ✅ Skip if the user already exists in `User` table

            var roles = await _userManager.GetRolesAsync(identityUser);
            string role = roles.Any() ? string.Join(", ", roles) : "User"; // Default to "User" role

            var newUser = new User
            {
                Email = identityUser.Email,
                Password = identityUser.PasswordHash, // ✅ Keep hashed password
                Name = identityUser.UserName, // ✅ Change this to `FullName` if needed
                Role = role,
                PhoneNumber = identityUser.PhoneNumber,
                Address = null,
            };

            dbContext.User.Add(newUser); // ✅ `Id` is auto-incremented by the database
        }

        await dbContext.SaveChangesAsync();
    }
}
