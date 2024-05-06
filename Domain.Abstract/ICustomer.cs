namespace Domain_Abstract;
public interface ICustomer : IEntity
{
	string Cpf { get; set; }
	string Name { get; set; }
	string Address { get; set; }
	string Email { get; set; }
}
