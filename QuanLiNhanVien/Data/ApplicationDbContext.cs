using Microsoft.EntityFrameworkCore;
using QuanLiNhanVien.Models;

namespace QuanLiNhanVien.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Department> departments { get; set; }  // Đổi từ Department → departments
        public DbSet<Employee> employees { get; set; }      // Đổi từ Employee → employees
        public DbSet<Position> positions { get; set; }      // Đổi từ Position → positions
    }

}