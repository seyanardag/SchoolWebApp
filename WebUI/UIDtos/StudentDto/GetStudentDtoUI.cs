namespace WebUI.UIDtos.StudentDto
{
    public class GetStudentDtoUI
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime EnrollmentDate { get; set; }  //Kayıt Tarihi
        public bool isDeleted { get; set; } = false; //Default olarak false ayarladık
        public string ImgUrl { get; set; }

    }
}
