﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ThePaySourceClient.PayRollModel
{
    public class Title
    {
        public int ID { get; set; }

        [Display(Name = "title")]
        public string Name { get; set; }


        public virtual ICollection<StaffProfile> Staffprofile { get; set; }
        public virtual ICollection<Employees> Employees { get; set; }
    }
}