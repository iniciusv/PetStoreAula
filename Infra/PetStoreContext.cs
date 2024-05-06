using Domain;
using Domain_Abstract;
using Microsoft.EntityFrameworkCore;

namespace Infra;
public class PetStoreContext : DbContext
{
	public DbSet<Customer> Customers { get; set; }
	public DbSet<Pet> Pets { get; set; }
	public DbSet<Phone> Phones { get; set; }
	public DbSet<SpecialNeed> SpecialNeeds { get; set; }


	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		// Configura a conexão com o LocalDB
		optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=PetStoreDB;Trusted_Connection=True;");
	}
}