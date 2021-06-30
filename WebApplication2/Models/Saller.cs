using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace WebApplication2.Models {
    public class Saller {
        public int Id { get; set; }
        [Required(ErrorMessage ="{0} obrigatorio")]
        [StringLength(60, MinimumLength = 3, ErrorMessage ="O nome deve ter entre 3 e 60 caracteres")]
        public string Name { get; set; }

        [Required(ErrorMessage = "{0} obrigatorio")]
        [EmailAddress(ErrorMessage ="Entre com um email valido")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "{0} obrigatorio")]
        [Display(Name= "Birth Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "{0} obrigatorio")]
        [Range(100.0, 50000.00, ErrorMessage ="{0} must from {1} to {2}")]
        [Display(Name = "Base Salary")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double BaseSalary { get; set; }

        [Required(ErrorMessage = "{0} obrigatorio")]
        public Department Department { get; set; }
        public int DepartmentId { get; set; }
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();

        public Saller() {
        }

        public Saller(int id, string name, string email, DateTime birthDate, double baseSalary, Department department) {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
            Department = department;
        }
        public void AddSales(SalesRecord sr) {
            Sales.Add(sr);
        }
        public void RemoveSales(SalesRecord sr) {
            Sales.Remove(sr);
        }

        public double TotalSales(DateTime initial, DateTime final) {
            return Sales.Where(sr => sr.Date >= initial && sr.Date <= final).Sum(sr => sr.Amount);
        }
    }

}
