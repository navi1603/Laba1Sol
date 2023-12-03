using Microsoft.AspNetCore.Identity;

namespace Laba1.DAL.Entities
{
	public class ApplicationUser: IdentityUser
	{
		public byte[] AvatarImage { get; set; } = new byte[0];
    }
}
