using Microsoft.EntityFrameworkCore;

namespace AuthLabTrackOne.DataAccess
{
    public class AuthLabTrackOneContext : DbContext
    {
        public AuthLabTrackOneContext(DbContextOptions<AuthLabTrackOneContext> options) : base(options)
        {

        }
    }
}
