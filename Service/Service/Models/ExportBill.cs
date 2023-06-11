﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Service.Models
{
    public partial class ExportBill
    {
        public int ExId { get; set; }
        public string ExManager { get; set; }
        public DateTime ExDate { get; set; }
        public int AccId { get; set; }
        public int CusId { get; set; }

        public virtual Account Acc { get; set; }
        public virtual Customer Cus { get; set; }
    }
}
