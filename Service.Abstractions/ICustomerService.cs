using Infra;
namespace Service.Abstractions;
public interface ICustomerService
{
	CustomerDTO GetCustomerById(int id);
	void AddCustomer(CustomerDTO customerDto);
	void UpdateCustomer(CustomerDTO customerDto);
	void DeleteCustomer(int id);
	IEnumerable<CustomerDTO> GetAllCustomers();
}
