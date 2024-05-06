using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Infra.Abstractions;

public interface IRepository<T> where T : class
{
	T GetById(long ID);
	IEnumerable<T> GetAll();
	void Add(T entity);
	void Update(T entity);
	void Delete(T entity);
}

