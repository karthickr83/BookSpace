using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BMWModels
{
    [Table("MemberMaster")]
    public class MemberMaster
    {
        [Key]
        public int MemberID { set; get; }

        public string MemberName { set; get; }
        public string Address { set; get; }
        public string City { set; get; }
        public string State { set; get; }
        public string Email { set; get; }
        public int? ContactNumber { set; get; }
        public int? MembershipID { set; get; }
        public DateTime? MembershipStartedDate { set; get; }
        public DateTime? MembershipExpiryDate { set; get; }
        public DateTime? RenewalAlertDate { set; get; }
        public DateTime? MembershipPriceOnDate { set; get; }
        public int? CreatedBy { set; get; }
        public DateTime? CreatedDateTime { set; get; }
        public int? ModifyBy { set; get; }
        public DateTime? ModifyDateTime { set; get; }

    }
}
