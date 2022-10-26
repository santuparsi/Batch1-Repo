using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace HandsOnEFCodeFirst_Demo2.Entities
{
    [Table("Project")]
    public class Project
    {
        [Key]
        [Column(TypeName ="char")]
        [StringLength(5)]
        public string ProjectCode { get; set; }
        [Required]
        [StringLength(20)]
        public string ProjectName { get; set; }
        public int? TeamSize { get; set; }
    }
}
