using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BMWModels
{
    [Table("ClientSpaceFacility")]
    public class ClientSpaceFacility
    {
        [Key]
        public int ClientSpaceFacilityID { set; get; }

        public int ClientID { set; get; }
        public int ClientLocationID { set; get; }
        public int ClientFloorID { set; get; }
        public int ClientSpaceFloorPlanID { set; get; }
        public int FacilityID { set; get; }
        public bool Available { set; get; }
        public bool IsPaidAmenity { set; get; }
        public int? CreateBy { set; get; }
        public DateTime? CreatedDateTime { set; get; }
        public int? ModifyBy { set; get; }
        public DateTime? ModifyDateTime { set; get; }
    }
}
