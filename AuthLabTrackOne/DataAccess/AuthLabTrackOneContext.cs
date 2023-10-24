using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using AuthLabTrackOne.Models;

namespace AuthLabTrackOne.DataAccess
{
    public class AuthLabTrackOneContext : DbContext
    {
        public AuthLabTrackOneContext(DbContextOptions<AuthLabTrackOneContext> options) : base(options)
        {

        }
    }
}
