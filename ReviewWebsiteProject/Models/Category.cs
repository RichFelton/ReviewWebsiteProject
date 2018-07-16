using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReviewWebsiteProject.Models
{
    public class Category
    {
        public int ID { get; set; }
        public string PhoneMaker { get; set; }
        public string PhoneModel { get; set; }
        public double PhonePrice { get; set; }
        public int MemorySize { get; set; }
        public double ScreenSize { get; set; }
        public string OperatingSystem { get; set; }

        public virtual ICollection<Review> Reviews { get; set; }
    }
}