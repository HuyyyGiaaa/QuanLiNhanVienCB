using QuanLiNhanVien.Data;
using QuanLiNhanVien.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace QuanLiNhanVien.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            try
            {
                var departments = _context.departments.ToList();
                var employees = _context.employees.ToList();
                var positions = _context.positions.ToList();
                
                ViewBag.Message = $"Kết nối thành công! Đã tải: {departments.Count} phòng ban, {employees.Count} nhân viên và {positions.Count} chức vụ.";
                ViewBag.Departments = departments;
                ViewBag.Employees = employees;
                ViewBag.Positions = positions;
            }
            catch (Exception ex)
            {
                ViewBag.Message = "Kết nối thất bại: " + ex.Message;
                ViewBag.Departments = new List<Department>();
                ViewBag.Employees = new List<Employee>();
                ViewBag.Positions = new List<Position>();
            }

            return View();
        }
    }
}