using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace INTEX.Models
{
    public partial class artifactkomaushimregister
    {
        [Key]
        [Required]
        public long id { get; set; }
        public string provenance { get; set; }
        public string description { get; set; }
        public string position { get; set; }
        public string qualityphotos { get; set; }
        public string finder { get; set; }
        public string dimensions { get; set; }
        public string material { get; set; }
        public string rehousedto { get; set; }
        public string photos { get; set; }
        public string number { get; set; }
        public string remarks { get; set; }
        public DateTime? entrydate { get; set; }
        public string currentlocation { get; set; }
        public string excavatornum { get; set; }
        public string date { get; set; }
    }
}
