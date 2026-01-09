using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLiNhanVien.Models
{
    [Table("positions")]
    public class Position
    {
        [Key]
        [Column("pos_id")]
        public int PositionId { get; set; }

        [Column("pos_title")]
        public string PositionTitle { get; set; } = null!;

        [Column("base_salary")]
        public decimal BaseSalary { get; set; }
    }
}
