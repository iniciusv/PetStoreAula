using Infra.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace Infra;
public class Repository<T> : IRepository<T> where T : class
{
	protected readonly DbContext _context;
	private readonly DbSet<T> _set;

	public Repository(DbContext context)
	{
		_context = context;
		_set = context.Set<T>();
	}

	public T GetById(long  ID)
	{
		return _set.Find(ID);
	}

	public IEnumerable<T> GetAll()
	{
		return _set.ToList();
	}

	public void Add(T entity)
	{
		_set.Add(entity);
		_context.SaveChanges();
	}

	public void Update(T entity)
	{
		_set.Update(entity);
		_context.SaveChanges();
	}

	public void Delete(T entity)
	{
		_set.Remove(entity);
		_context.SaveChanges();
	}
}
