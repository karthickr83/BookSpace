﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace BMWModels
{
    [Table("UserLogin")]
    public class UserLogin
    {
        [Key]
        public int UserID { set; get; }

        public string Username { set; get; }
        public string Password { set; get; }
        public int UserType { set; get; }

		[DisplayName("Status")]
        public bool Active { set; get; }
        public int? MemberID { set; get; }
        public int? ClientID { set; get; }
        public int? ClientLocationID { set; get; }
        public DateTime? LastLoginDateTime { set; get; }
        public Int64? LoginCount { set; get; }
        public int? CreatedBy { set; get; }
        public DateTime? CreatedDateTime { set; get; }
        public int? ModifyBy { set; get; }
        public DateTime? ModifyDateTime { set; get; }
    }
}
