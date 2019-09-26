using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BMWModels
{
    [Table("ClientFloor")]
    public class ClientFloor
    {
        [Key]
        public int ClientFloorID { set; get; }

        public int? ClientID { set; get; }

        public int? ClientLocationID { set; get; }

        public int? FloorNumber { set; get; }

        public string FloorPlanFilePath { set; get; }

        public double? PaidAmenitiesPrice { set; get; }

        public int? CreatedBy { set; get; }

        public DateTime? CreatedDateTime { set; get; }
    }
}
