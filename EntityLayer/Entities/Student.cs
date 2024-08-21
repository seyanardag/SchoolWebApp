using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{

    //Öğrenciye ait temel ad, soyad, doğum tarihi gibi bilgilerin tutulacağı entity;
	public class Student
	{
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime EnrollmentDate { get; set; }  //Kayıt Tarihi
		public bool isDeleted { get; set; } = false; //Default olarak false ayarladık
        public string ImgUrl {  get; set; }
        

    }
}
