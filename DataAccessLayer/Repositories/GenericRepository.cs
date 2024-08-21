using DataAccessLayer.Abstract;
using DataAccessLayer.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
	//T tipinde gelen herhangi bir entity e ait temel database işlemlerinin gerçekleştirilmesi. Bu işlemler zaten bütün Entity ler için kullanılacak olan işlemler ve Repository Design Pattern sayesinde bu işlemleri her bir Entity için ayrı ayrı yazmak zorunda kalmıyoruz. 
	public class GenericRepository <T> : IGenericDal<T> where T : class
	{

		private readonly SchoolDbContext _context;

		public GenericRepository(SchoolDbContext context)
		{
			_context = context;
		}

		public async Task AddAsync(T entity)
		{
			await _context.Set<T>().AddAsync(entity);
			await _context.SaveChangesAsync();
		}
		
		public async Task DeleteAsync(int id)
		{
			var valueToDel = await _context.Set<T>().FindAsync(id);
			if (valueToDel != null)
			{
				_context.Set<T>().Remove(valueToDel);
				await _context.SaveChangesAsync();
			}
			else
			{
				//Silme işleminde geçerli olmayan id verilirse hata fırlatsın;
				throw new InvalidOperationException("Bu id ile herhangi bir giriş bulunamadı");
			}
		}

		public async Task<List<T>> GetAllAsync()
		{
			return await _context.Set<T>().ToListAsync();
		}

		public async Task<T> GetByIdAsync(int id)
		{
			var entity = await _context.Set<T>().FindAsync(id);
			if (entity != null) { return entity; }
			else throw new InvalidOperationException("Bu id ile herhangi bir giriş bulunamadı"); //ID ye göre getirme işleminde geçerli olmayan id verilirse hata fırlatsın;
		}

		public async Task UpdateAsync(T entity)
		{
			_context.Set<T>().Update(entity);
			await _context.SaveChangesAsync();
		}
	}
}