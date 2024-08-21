using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLayer.StudentDto
{
	//Create Dto da Id bulunmaz, zaten bu database e eklenirken yeni Id oluşturularak eklenir. Diper propertylerden data aktarılmak istediklerimizi Dto yapısına aşağıdaki gibi dahil ettik (burada hepsini)
	public class CreateStudentDto
	{
		
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public DateTime BirthDate { get; set; }
		public DateTime EnrollmentDate { get; set; }  //Kayıt Tarihi
		public bool isDeleted { get; set; }
		public string ImgUrl { get; set; }

	}
}
