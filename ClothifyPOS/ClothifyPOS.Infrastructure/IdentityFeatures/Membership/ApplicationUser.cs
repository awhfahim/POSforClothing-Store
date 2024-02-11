using Microsoft.AspNetCore.Identity;

namespace ClothifyPOS.Infrastructure.IdentityFeatures.Membership
{
	public class ApplicationUser : IdentityUser<Guid>
	{
		public string? FullName { get; set; }
    }
}
