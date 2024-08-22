using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
	public interface IStudentDal : IGenericDal<Student>
	{
		Task<List<Student>> GetDeletedStudentList();
		Task<Student> SoftDeletestudentAsync(int id);
		Task<Student> HardDeletestudentAsync(int id);
		Task<Student> UnDeletestudentAsync(int id);
	}
}
