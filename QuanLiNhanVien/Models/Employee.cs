using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLiNhanVien.Models
{
    [Table("employees")]
    public class Employee
    {
        [Key]
        [Column("emp_id")]
        public int EmpId { get; set; }

        [Column("full_name")]
        public string FullName { get; set; } = null!;

        [Column("gender")]
        public string Gender { get; set; } = null!;

        [Column("birth_date")]
        public DateTime? BirthDate { get; set; }

        [Column("phone")]
        public string Phone { get; set; } = null!;

        [Column("email")]
        public string Email { get; set; } = null!;

        [Column("hire_date")]
        public DateTime? HireDate { get; set; }

        [Column("dept_id")]
        public int? DeptId { get; set; }

        [Column("pos_id")]
        public int? PosId { get; set; }

        [ForeignKey("DeptId")]
        public Department? Department { get; set; }

        [ForeignKey("PosId")]
        public Position? Position { get; set; }
    }
}