using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Service.Models
{
    public partial class Customer
    {
        public Customer()
        {
            ExportBills = new HashSet<ExportBill>();
        }
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CusId { get; set; }
        public string CusName { get; set; }
        public int CusGender { get; set; }
        public DateTime CusDob { get; set; }
        public string CusPhone { get; set; }

        public virtual ICollection<ExportBill> ExportBills { get; set; }
    }
}
