namespace Domain_Abstract
{
	public interface IPhone : IEntity
	{
		long CustomerId { get; set; }
		string Ddd { get; set; }
		string Number { get; set; }
	}
}
