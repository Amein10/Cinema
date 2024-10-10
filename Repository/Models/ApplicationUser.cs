using Microsoft.AspNetCore.Identity;

namespace Repository.Models
{
    public class ApplicationUser : IdentityUser
    {
        // Du kan tilføje ekstra egenskaber som f.eks. fuldt navn osv.
        public string FullName { get; set; }
    }
}
