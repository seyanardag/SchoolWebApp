using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class StudentManager : IStudentService
	{
		private readonly IStudentDal _studentDal;

		public StudentManager(IStudentDal studentDal)
		{
			_studentDal = studentDal;
		}

		public Task TAddAsync(Student entity)
		{
			return _studentDal.AddAsync(entity);
		}

		public Task TDeleteAsync(int id)
		{
			return (_studentDal.DeleteAsync(id));
		}

		public Task<List<Student>> TGetAllAsync()
		{
			return _studentDal.GetAllAsync();
		}

		public Task<Student> TGetByIdAsync(int id)
		{
			return _studentDal.GetByIdAsync(id);
		}

		public Task<List<Student>> TGetDeletedStudentList()
		{
			return _studentDal.GetDeletedStudentList();
		}

		public Task<Student> THardDeletestudentAsync(int id)
		{
			return _studentDal.HardDeletestudentAsync(id);
		}

		public Task<Student> TSoftDeletestudentAsync(int id)
		{
			return _studentDal.SoftDeletestudentAsync(id);
		}

        public Task<Student> TUnDeletestudentAsync(int id)
        {
            return _studentDal.UnDeletestudentAsync(id) ;
        }

        public Task TUpdateAsync(Student entity)
		{
			return _studentDal.UpdateAsync(entity);
		}
	}
}
