namespace Domain_Abstract;
public interface IPet : IEntity
{
	string Name { get; set; }
	string Species { get; set; }
	string Breed { get; set; }
	string Size { get; set; }
	long CustomerId { get; set; }
}
