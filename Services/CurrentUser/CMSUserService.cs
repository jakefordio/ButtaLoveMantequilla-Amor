using ButtaLove.Data;
using ButtaLove.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ButtaLove.Services.CurrentUser;

public class AppUserService(
    AppDbContext dbContext,
    UserManager<AppUser> userManager,
    SignInManager<AppUser> signInManager,
    RoleManager<IdentityRole> roleManager)
    : ControllerBase
{
    private readonly UserManager<AppUser> _userManager = userManager;
    private readonly SignInManager<AppUser> _signInManager = signInManager;
    private readonly RoleManager<IdentityRole> _roleManager = roleManager;

    public AppUser GetCurrentAppUser()
    {
        AppUser user = dbContext.AppUsers.Where(u => u.UserName == User.Identity.Name).Select(cmsu => new AppUser()
        {
            Id = cmsu.Id,
            BirthDate = cmsu.BirthDate,
            FirstName = cmsu.FirstName,
            LastName = cmsu.LastName,
            PhoneNumber = cmsu.PhoneNumber,
            City = cmsu.City,
            State = cmsu.State,
            Zip =  cmsu.Zip,
            IsOnline = cmsu.IsOnline,
            UserName = cmsu.UserName,
            Email = cmsu.Email
        }).FirstOrDefault();
        
        return user;
    }
}