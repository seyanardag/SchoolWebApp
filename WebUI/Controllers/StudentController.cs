using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;

using System.Text;
using WebUI.CustomServices.Abstract;
using WebUI.UIDtos.StudentDto;
using WebUI.UIDtos.Validations;

namespace WebUI.Controllers
{
  
	public class StudentController : Controller
	{
		private readonly IHttpClientFactory _httpClientFactory;
        private readonly IFileUploadService _fileUploadService;
        public StudentController(IHttpClientFactory httpClientFactory, IFileUploadService fileUploadService)
        {
            _httpClientFactory = httpClientFactory;
			_fileUploadService = fileUploadService;
        }

        public async Task<IActionResult> Index()
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("https://localhost:7041/api/Student/StudentList");
			
			if(responseMessage.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<List<ResultStudentDtoUI>>(jsonData);
				return View(values);
			}


			return View();
		}


		[HttpGet]
		public IActionResult CreateStudent()
		{
			return View();
		}



        [HttpPost]
        public async Task<IActionResult> CreateStudent(CreateStudentDtoUI createStudentDtoUI)
        {

            var validator = new CreateStudentDtoUIValidator();
            ValidationResult validationResult = validator.Validate(createStudentDtoUI);

            if (!validationResult.IsValid)
            {               
                foreach (var error in validationResult.Errors)
                {
                    ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
                }
                return View(createStudentDtoUI);
            }




            createStudentDtoUI.ImgUrl = await _fileUploadService.UploadFileAsync(createStudentDtoUI.ImgFile, "images/studentImages");

           
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createStudentDtoUI);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("https://localhost:7041/api/Student", stringContent);

            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            
            return View(createStudentDtoUI);
        }



        public async Task<IActionResult> SoftDeleteStudent(int id)
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.DeleteAsync($"https://localhost:7041/api/Student/SoftDeleteStudent/{id}");
			
			return RedirectToAction("Index", "Student");
		}

        public async Task<IActionResult> UpdateStudent(int id)
        {          
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync($"https://localhost:7041/api/Student/{id}");
			if (responseMessage.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var value = JsonConvert.DeserializeObject<UpdateStudentDtoUI>(jsonData);
				return View(value);			
			}

            return Problem();
        }


		[HttpPost]
        public async Task<IActionResult> UpdateStudent(UpdateStudentDtoUI updateStudentDtoUI)
        {

            var validator = new UpdateStudentDtoUIValidator();
            ValidationResult validationResult = validator.Validate(updateStudentDtoUI);

            if (!validationResult.IsValid)
            {
                foreach (var error in validationResult.Errors)
                {
                    ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
                }
                return View(updateStudentDtoUI);
            }






            //resim için işlemler
            if (updateStudentDtoUI.ImgFile != null && updateStudentDtoUI.ImgFile.Length > 0)
            {
                // Var olan dosya yolunu al
                var existingFilePath = updateStudentDtoUI.ImgUrl;

                // Yeni dosyayı yükle ve eski dosyayı sil
                var newFilePath = await _fileUploadService.UpdateFileAsync(updateStudentDtoUI.ImgFile, existingFilePath, "images/studentImages");

                // DTO'yu güncelle
                updateStudentDtoUI.ImgUrl = newFilePath;
            }


            //Api işlemleri
            var client = _httpClientFactory.CreateClient();
			var jsonData = JsonConvert.SerializeObject(updateStudentDtoUI);
			StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
			var responseMessage = await client.PutAsync("https://localhost:7041/api/Student",stringContent);

            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }

            return View();
        }





    }
}
