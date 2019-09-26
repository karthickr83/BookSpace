using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BMWModels
{
    [Table("MembershipPlan")]
    public class MembershipPlan
    {
        [Key]
        public int MembershipID { set; get; }

        public string MembershipName { set; get; }
        public int? MembershipDuration { set; get; }
        public string MembershipDurationType { set; get; }        
        public double? Price { set; get; }
    }
}
