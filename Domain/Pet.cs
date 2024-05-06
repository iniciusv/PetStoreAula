using Domain_Abstract;

namespace Domain;

public class Pet : IPet
{
	public long ID { get; set; }
	public string Name { get; set; }
	public string Species { get; set; }
	public string Breed { get; set; }
	public string Size { get; set; }
	public long CustomerId { get; set; }
	public List<SpecialNeed> SpecialNeeds { get; set; }
}
