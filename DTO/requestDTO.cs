using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Zero_Hunger.EF;

namespace Zero_Hunger.DTO
{
    public class requestDTO
    {
        public int id { get; set; }
        public string status { get; set; }
        public int total_quantity { get; set; }
        public int restaurant_id { get; set; }
        public int employee_id { get; set; }
        public int admin_id { get; set; }

        public virtual admin admin { get; set; }
        public virtual employee employee { get; set; }
        public virtual food food { get; set; }
        public virtual restaurant restaurant { get; set; }

    }
}