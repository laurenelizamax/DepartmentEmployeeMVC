﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DepartmentEmployeeMVC.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Display(Name = "First Name")]
        [Required]
        [MaxLength(15, ErrorMessage ="First Name must be less than 15 characters")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Department")]
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
