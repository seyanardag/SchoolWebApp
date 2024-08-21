using DataAccessLayer.Abstract;
using DataAccessLayer.Context;
using DataAccessLayer.Repositories;
using EntityLayer.Entities;
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
	}
}
