using Laba1.DAL.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Laba1.DAL.Data
{
	public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
	{
		//public ApplicationDbContext()
		//{
		//}
		public ApplicationDbContext(DbContextOptions options) : base(options)
		{
		}
		public DbSet<Dish> Dishes { get; set; }
		public DbSet<DishGroup> DishGroups { get; set; }




		//protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		//{
		//	optionsBuilder.UseSqlServer(@"Server=(localdb)\\mssqllocaldb;Database=aspnet-Laba1-Data;Trusted_Connection=True;MultipleActiveResultSets=true");
		//	//base.OnConfiguring(optionsBuilder);
		//}

	}
}
