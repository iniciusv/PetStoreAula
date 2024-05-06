
using Domain;
using Domain_Abstract;
using Infra.Abstractions;

namespace Infra;

public interface IUnitOfWork
{
	IRepository<Customer> Customers { get; }
	IRepository<Pet> Pets { get; }
	IRepository<Phone> Phones { get; }
	IRepository<SpecialNeed> SpecialNeeds { get; }
	void Commit();
}
