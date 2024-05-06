using Domain_Abstract;

namespace Domain
{
	public class SpecialNeed : ISpecialNeed
	{
		public long ID { get; set; }
		public long PetId { get; set; }
		public long Description { get; set; }
	}
}
