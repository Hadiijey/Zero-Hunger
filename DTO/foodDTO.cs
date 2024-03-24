using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Zero_Hunger.EF;

namespace Zero_Hunger.DTO
{
    public class foodDTO
    {
        public int id { get; set; }
        public string type { get; set; }
        public int quantity { get; set; }
        public int request_id { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<request> requests { get; set; }
    }
}