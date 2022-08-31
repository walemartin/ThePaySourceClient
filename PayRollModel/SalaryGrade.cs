﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ThePaySourceClient.PayRollModel
{
    public class SalaryGrade
    {
        public int ID { get; set; }

        [Display(Name = "salary grade")]
        public string Name { get; set; }
        public virtual ICollection<StaffProfile> Staffprofile { get; set; }
    }
}