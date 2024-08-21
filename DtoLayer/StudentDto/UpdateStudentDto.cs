using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLayer.StudentDto
{
	public class UpdateStudentDto
	{
		public int StudentId { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public DateTime BirthDate { get; set; }
		public DateTime EnrollmentDate { get; set; }  //Kayıt Tarihi
		public bool isDeleted { get; set; }
		public string ImgUrl { get; set; }

	}
}
