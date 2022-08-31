﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ThePaySourceClient.PayRollModel
{
    public class StateOfOrigin
    {
        public int ID { get; set; }

        [Display(Name = "state of origin")]
        public string Name { get; set; }

        public virtual ICollection<StaffProfile> Staffprofile { get; set; }
        public virtual ICollection<Employees> Employees { get; set; }
    }
}