using Infra.Abstractions;
using Infra;
using Domain_Abstract;
using Domain;

namespace Infra;
public class UnitOfWork : IUnitOfWork
{
	readonly PetStoreContext _context;

	public IRepository<Customer> Customers { get; private set; }
	public IRepository<Pet> Pets { get; private set; }
	public IRepository<Phone> Phones { get; private set; }
	public IRepository<SpecialNeed> SpecialNeeds { get; private set; }

	public UnitOfWork(PetStoreContext context)
	{
		_context = context;
		Customers = new Repository<Customer>(context);
		Pets = new Repository<Pet>(context);
		Phones = new Repository<Phone>(context);
		SpecialNeeds = new Repository<SpecialNeed>(context);
	}

	public void Commit()
	{
		_context.SaveChanges();
	}
}
