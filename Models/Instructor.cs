﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentExercisesMVC.Models
{
    public class Instructor
    {
        [Required]
        [Display]
        public int Id { get; set; }
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [Display(Name = "Slack handle")]
        public string SlackHandle { get; set;}
        [Required]
        public string Specialty { get; set; }
        [Required]
        [Display(Name = "Cohort Id")]
        public int CohortId { get; set; }
        [Display(Name = "Full Name")]
        public string FullName { get; set; }


    }
}
