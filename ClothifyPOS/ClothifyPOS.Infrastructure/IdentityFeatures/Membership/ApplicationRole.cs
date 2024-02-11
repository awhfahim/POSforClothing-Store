using Microsoft.AspNetCore.Identity;
using System;

namespace ClothifyPOS.Infrastructure.IdentityFeatures.Membership
{
	public class ApplicationRole : IdentityRole<Guid>
	{
		public ApplicationRole()
			: base()
		{
		}
		
		public ApplicationRole(string roleName)
			: base(roleName)
		{
		}
	}
}
