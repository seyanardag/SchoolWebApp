
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebUI.CustomServices.Abstract;
using WebUI.UIDtos.StudentDto;

namespace WebUI.Controllers
{
    public class DeletedStudentController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IFileUploadService _fileUploadService;

        public DeletedStudentController(IHttpClientFactory httpClientFactory, IFileUploadService fileUploadService)
        {
            _httpClientFactory = httpClientFactory;
            _fileUploadService = fileUploadService;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7041/api/Student/GetDeletedStudentList");

            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultStudentDtoUI>>(jsonData);
                return View(values);            
            }
            return View();
        }


        public async Task<IActionResult> HardDeleteStudent(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"https://localhost:7041/api/Student/HardDeleteStudent/{id}");

            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var student = JsonConvert.DeserializeObject<ResultStudentDtoUI>(jsonData);

            await _fileUploadService.DeleteFileAsync(student?.ImgUrl);

            return RedirectToAction("Index", "DeletedStudent");
        }

        public async Task<IActionResult> UnDeleteStudent(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7041/api/Student/UnDeleteStudent/{id}");
            return RedirectToAction("Index", "DeletedStudent");

        }


    }
}
