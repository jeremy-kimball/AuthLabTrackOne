using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AuthLabTrackOne.DataAccess
{
    public class AuthLabTrackOneContext : IdentityDbContext
    {
        public AuthLabTrackOneContext(DbContextOptions<AuthLabTrackOneContext> options) : base(options)
        {

        }
    }
}
