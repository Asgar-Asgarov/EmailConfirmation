using Microsoft.AspNetCore.Identity;
namespace EmailConfirmation.Models;
 
public class AppUser:IdentityUser
{
    public string FullName { get; set; }
}