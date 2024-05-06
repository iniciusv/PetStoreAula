using Domain_Abstract;

namespace Domain
{
	public class Phone : IPhone
	{
		public long ID { get; set; }
		public long CustomerId { get; set; }
		public string Ddd { get; set; }
		public string Number { get; set; }
	}
}
