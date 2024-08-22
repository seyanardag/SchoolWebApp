using DataAccessLayer.Abstract;
using DataAccessLayer.Context;
using DataAccessLayer.Repositories;
using EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
	//Generic Repository den miras alıyor ki repository design pattern gereği bütün CRUD işlemlerini de böylece kod tekrarsız geröekleştirsin. Ayrıca IStudentDal ı implemente etsin ki sadece Student Entity sine özgü imzası atılmış bir metod vs varsa bunları da burada tanımlayabilelim ve daha sonra kullanabilielim.
	public class EfStudentDal : GenericRepository<Student>, IStudentDal
	{
		public EfStudentDal(SchoolDbContext context) : base(context)
		{
		}

		public async Task<List<Student>> GetDeletedStudentList()
		{
			return await _context.Students.IgnoreQueryFilters().Where(x=>x.isDeleted).ToListAsync();
		}

		public async Task<Student> HardDeletestudentAsync(int id)
		{
			var student = await _context.Students.IgnoreQueryFilters().FirstOrDefaultAsync(x => x.StudentId == id);
			if (student == null)
			{
				return null;
			}

			_context.Students.Remove(student);
			await _context.SaveChangesAsync();

			return student;
		}

		public async Task<Student> SoftDeletestudentAsync(int id)
		{
			var student = await _context.Students.FindAsync(id);
			if (student == null)
			{
				return null;
			}

			student.isDeleted = true;
			await _context.SaveChangesAsync();

			return student;
		}

        public async Task<Student> UnDeletestudentAsync(int id)
        {
            var student = await _context.Students.IgnoreQueryFilters().FirstOrDefaultAsync(x => x.StudentId == id);
			if (student == null)
            {
                return null;
            }

            student.isDeleted = false;
            await _context.SaveChangesAsync();

            return student;

        }



    }
}
