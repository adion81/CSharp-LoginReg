using Microsoft.EntityFrameworkCore;

namespace LoginReg.Models
{
    public class HomeContext: DbContext
    {
        public HomeContext(DbContextOptions options) : base(options){}

        
    }
}