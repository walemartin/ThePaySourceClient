using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ThePaySourceClient.PayRollModel
{
    public class BankBranch
    {
        public int ID { get; set; }

        [Display(Name = "bank")]
        public string Bank { get; set; } = string.Empty;
        public virtual ICollection<StaffProfile> Staffprofile { get; set; }
        public virtual ICollection<WorkData> WorkDatas { get; set; }
    }
}