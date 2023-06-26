using System;
using System.Collections.Generic;

#nullable disable

namespace Service.Models
{
    public partial class Provider
    {
        public Provider()
        {
            ImportBills = new HashSet<ImportBill>();
        }

        public int txtProviderID { get; set; }
        public string ProName { get; set; }
        public int ProGender { get; set; }
        public string ProPhone { get; set; }
        public DateTime ProDob { get; set; }

        public virtual ICollection<ImportBill> ImportBills { get; set; }
    }
}
