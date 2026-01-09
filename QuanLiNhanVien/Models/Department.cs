using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLiNhanVien.Models
{
    [Table("departments")]
    public class Department
    {
        [Key]
        [Column("dept_id")]
        public int DeptId { get; set; } 

        [Column("dept_name")]
        public string DeptName { get; set; } = null!;

        [Column("location")]
        public string Location { get; set; } = null!;
    }
}

