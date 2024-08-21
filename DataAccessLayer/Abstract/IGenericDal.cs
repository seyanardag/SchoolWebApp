using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
	public interface IGenericDal <T> where T : class
	{
		Task AddAsync(T entity);
		Task DeleteAsync(int id);
		Task UpdateAsync(T entity);
		Task<T> GetByIdAsync(int id);
		Task<List<T>> GetAllAsync();
	}
}
