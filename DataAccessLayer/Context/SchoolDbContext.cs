using EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Context
{
	public class SchoolDbContext : DbContext
	{
		public SchoolDbContext(DbContextOptions<SchoolDbContext> options) : base(options)
		{
		}


		//Öğrencilere ait tablonun oluşturulması
		public DbSet<Student> Students { get; set; }


		//OnModelCreating metodunun override edilerek Database in Seedlenmesi
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Student>().HasData(

			new Student() { StudentId = 1, FirstName = "Mehmet", LastName = "Ekinci", BirthDate = new DateTime(2002, 5, 15), EnrollmentDate = new DateTime(2023, 9, 12), ImgUrl = "/images/studentImages/e1.png" },
			new Student() { StudentId = 2, FirstName = "Ali", LastName = "Yılmaz", BirthDate = new DateTime(2001, 6, 20), EnrollmentDate = new DateTime(2023, 9, 10), ImgUrl = "/images/studentImages/e2.png" },
			new Student() { StudentId = 3, FirstName = "Ahmet", LastName = "Çelik", BirthDate = new DateTime(2002, 7, 25), EnrollmentDate = new DateTime(2023, 8, 9), ImgUrl = "/images/studentImages/e3.png" },
			new Student() { StudentId = 4, FirstName = "Mehmet", LastName = "Demir", BirthDate = new DateTime(2003, 8, 30), EnrollmentDate = new DateTime(2023, 8, 11), ImgUrl = "/images/studentImages/e4.png" },
			new Student() { StudentId = 5, FirstName = "Zeynep", LastName = "Kara", BirthDate = new DateTime(2002, 5, 10), EnrollmentDate = new DateTime(2023, 9, 22), ImgUrl = "/images/studentImages/k1.png" },
			new Student() { StudentId = 6, FirstName = "Elif", LastName = "Yurt", BirthDate = new DateTime(2001, 6, 15), EnrollmentDate = new DateTime(2023, 8, 2), ImgUrl = "/images/studentImages/k2.png" },
			new Student() { StudentId = 7, FirstName = "Fatma", LastName = "Öztürk", BirthDate = new DateTime(2003, 7, 22), EnrollmentDate = new DateTime(2023, 7, 1), ImgUrl = "/images/studentImages/k3.png" },
			new Student() { StudentId = 8, FirstName = "Emine", LastName = "Aydın", BirthDate = new DateTime(2002, 8, 17), EnrollmentDate = new DateTime(2023, 10, 18), ImgUrl = "/images/studentImages/k4.png" },
			new Student() { StudentId = 9, FirstName = "Ayşe", LastName = "Güneş", BirthDate = new DateTime(2001, 9, 5), EnrollmentDate = new DateTime(2023, 8, 3), ImgUrl = "/images/studentImages/k5.png" },
			new Student() { StudentId = 10, FirstName = "Burak", LastName = "Koç", BirthDate = new DateTime(2002, 10, 12), EnrollmentDate = new DateTime(2023, 7, 22), ImgUrl = "/images/studentImages/e5.png" },
			new Student() { StudentId = 11, FirstName = "Emre", LastName = "Arslan", BirthDate = new DateTime(2003, 11, 23), EnrollmentDate = new DateTime(2023, 10, 13), ImgUrl = "/images/studentImages/e6.png" },
			new Student() { StudentId = 12, FirstName = "Oğuz", LastName = "Turan", BirthDate = new DateTime(2002, 12, 8), EnrollmentDate = new DateTime(2023, 8, 23), ImgUrl = "/images/studentImages/e7.png" },
			new Student() { StudentId = 13, FirstName = "Cem", LastName = "Sönmez", BirthDate = new DateTime(2001, 4, 4), EnrollmentDate = new DateTime(2023, 9, 30), ImgUrl = "/images/studentImages/e8.png" }

			);
		}


	}
}
