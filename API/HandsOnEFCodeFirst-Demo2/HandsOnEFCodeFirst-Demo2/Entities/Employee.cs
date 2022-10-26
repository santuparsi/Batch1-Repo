using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace HandsOnEFCodeFirst_Demo2.Entities
{
    [Table("Employee")]
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        [Required]
        [StringLength(20)]
        public string EmployeeName { get; set; }
        [ForeignKey("Project")]
        [StringLength(5)]
        [Column(TypeName ="char")]
        public string ProjectCode { get; set; }
        
        public Project Project { get; set; } //naviagation prop
    }
}
