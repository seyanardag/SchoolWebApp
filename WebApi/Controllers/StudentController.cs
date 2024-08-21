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

		[HttpGet]
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

		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteStudent(int id)
		{
			await _studentService.TDeleteAsync(id);
			return Ok("Öğrenci silme başarılı");
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
