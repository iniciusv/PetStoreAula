namespace Domain_Abstract;
public interface ISpecialNeed : IEntity
{
	long PetId { get; set; }
	long Description { get; set; }
}
