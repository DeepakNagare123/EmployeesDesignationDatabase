using System.ComponentModel.DataAnnotations;

namespace EmployeesDesignation.Models
{
    public class EmployeeData
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]

        public string? Designation { get; set; }
        [Required]
        [Display(Name="Date of Join")]
        public DateOnly DOJ {  get; set; }
        [Required]
        public double Salary {  get; set; }
        [Required]
        public string? Gender {  get; set; }
        [Required]
        public string? State { get; set; }
    }
}
