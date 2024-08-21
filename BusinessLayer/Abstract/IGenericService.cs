﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface IGenericService<T> where T : class
	{
		Task TAddAsync(T entity);
		Task TDeleteAsync(int id);
		Task TUpdateAsync(T entity);
		Task<T> TGetByIdAsync(int id);
		Task<List<T>> TGetAllAsync();

	}
}
