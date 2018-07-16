using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ReviewWebsiteProject.Models
{
    public class Review
    {
        [Key]
        public int ReviewID { get; set; }
        public string Author { get; set; }
        public string WherePublished { get; set; }
        public DateTime PublishDate { get; set; }

        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}