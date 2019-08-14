using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentExercisesMVC.Models.ViewModels
{
    public class Cohort
    {
        public int Id { get; set; }
        public string Name { get; internal set; }
    }
}
