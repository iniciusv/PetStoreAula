using Domain_Abstract;

namespace Domain;

public class Customer : ICustomer
{
	public long ID { get; set; }
	public string Cpf { get; set; }
	public string Name { get; set; }
	public string Address { get; set; }
	public string Email { get; set; }
	public List<Phone> Phones { get; set; }
	public List<Pet> Pets { get; set; }
}
