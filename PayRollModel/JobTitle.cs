using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ThePaySourceClient.PayRollModel
{
    public class JobTitle
    {
        public int ID { get; set; }

        [Display(Name = "Job title")]
        public string Name { get; set; }
        public virtual ICollection<StaffProfile> Staffprofile { get; set; }
        public virtual ICollection<WorkData> WorkDatas { get; set; }
    }
}