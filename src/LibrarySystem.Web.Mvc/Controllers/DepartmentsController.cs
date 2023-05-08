using LibrarySystem.Controllers;
using LibrarySystem.Departments.Dto;
using LibrarySystem.Departments;
using LibrarySystem.Web.Models.Departments;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace LibrarySystem.Web.Controllers
{
    public class DepartmentsController : LibrarySystemControllerBase
    {
        private readonly IDepartmentAppService _departmentAppService;

        public DepartmentsController(IDepartmentAppService departmentAppService)
        {
            _departmentAppService = departmentAppService;
        }
        public async Task<IActionResult> Index()
        {
            var departments = await _departmentAppService.GetAllAsync(new PagedDepartmentResultRequestDto { MaxResultCount = int.MaxValue });
            var model = new DepartmentListViewModel()
            {
                Departments = departments.Items.ToList()
            };

            return View(model);
        }
    }
}
