using AutoMapper;
using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DtoLayer.StudentDto;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class StudentController : ControllerBase
	{
		private readonly IStudentService _studentService;

		private readonly IMapper _mapper;

		public StudentController(IStudentService studentService, IMapper mapper)
		{
			_studentService = studentService;
			_mapper = mapper;
		}

		[HttpGet("StudentList")]
		public async Task<IActionResult> StudentList()
		{
			var values = await _studentService.TGetAllAsync();
			return Ok(values);
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetStudentById(int id)
		{
			var value = await _studentService.TGetByIdAsync(id);
			return Ok(value);
		}
		[HttpGet("GetDeletedStudentList")]
		public async Task<IActionResult> GetDeletedStudentList()
		{
			var values = await _studentService.TGetDeletedStudentList();
			return Ok(values);
		}

		[HttpPost()]
		public async Task<IActionResult> CreateStudent(CreateStudentDto createStudentDto )
		{
			var value = _mapper.Map<Student>(createStudentDto);
			await _studentService.TAddAsync(value);
			return Ok("Öğrenci oluşturma başarılı");
		}

		[HttpDelete("SoftDeleteStudent/{id}")]
		public async Task<IActionResult> SoftDeleteStudent(int id)
		{

			var deletedStudent = await _studentService.TSoftDeletestudentAsync(id);
			return Ok(deletedStudent);

	
		}

		[HttpDelete("HardDeleteStudent/{id}")]
		public async Task<IActionResult> HardDeleteStudent(int id)
		{

			var deletedStudent = await _studentService.THardDeletestudentAsync(id);
			return Ok(deletedStudent);

		}

		[HttpGet("UnDeleteStudent/{id}")]
        public async Task<IActionResult> UnDeleteStudent(int id)
        {
			var valueToUndelete = await _studentService.TUnDeletestudentAsync(id);
			return Ok(valueToUndelete);
        }


        [HttpPut()]
		public async Task<IActionResult> UpdateStudent(UpdateStudentDto updateStudentDto)
		{
			Student studentToUpdate = _mapper.Map<Student>(updateStudentDto);
			await _studentService.TUpdateAsync(studentToUpdate);

			return Ok("Öğrenci güncelleme başarılı");
		}


	}
}
