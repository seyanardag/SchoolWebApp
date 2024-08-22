using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface IStudentService : IGenericService<Student>
	{
		Task<List<Student>> TGetDeletedStudentList();
		Task<Student> TSoftDeletestudentAsync(int id);
		Task<Student> THardDeletestudentAsync(int id);
		Task<Student> TUnDeletestudentAsync(int id);
	}
}
