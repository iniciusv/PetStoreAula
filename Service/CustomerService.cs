using Domain;
using Domain_Abstract;
using Infra;
using Infra.Abstractions;
using Service.Abstractions;

namespace Service;

public class CustomerService
{
	private readonly ICustomerService _customerRepository;

	public CustomerService(ICustomerService customerRepository)
	{
		_customerRepository = customerRepository;
	}

	public CustomerDTO GetCustomerById(int id)
	{
		return _customerRepository.GetCustomerById(id);
	}

	public void AddCustomer(CustomerDTO customerDto)
	{
		_customerRepository.AddCustomer(customerDto);
	}
}