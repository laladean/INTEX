﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace INTEX.Models
{
    public partial class burialmain
    {
        [Key]
        [Required]
        public long id { get; set; }
        public string squarenorthsouth { get; set; }
        public string headdirection { get; set; }
        public string sex { get; set; }
        public string northsouth { get; set; }
        public string depth { get; set; }
        public string eastwest { get; set; }
        public string adultsubadult { get; set; }
        public string facebundles { get; set; }
        public string southtohead { get; set; }
        public string preservation { get; set; }
        public string fieldbookpage { get; set; }
        public string squareeastwest { get; set; }
        public string goods { get; set; }
        public string text { get; set; }
        public string wrapping { get; set; }
        public string haircolor { get; set; }
        public string westtohead { get; set; }
        public string samplescollected { get; set; }
        public string area { get; set; }
        public long? burialid { get; set; }
        public string length { get; set; }
        public string burialnumber { get; set; }
        public string dataexpertinitials { get; set; }
        public string westtofeet { get; set; }
        public string ageatdeath { get; set; }
        public string southtofeet { get; set; }
        public string excavationrecorder { get; set; }
        public string photos { get; set; }
        public string hair { get; set; }
        public string burialmaterials { get; set; }
        public DateTime? dateofexcavation { get; set; }
        public string fieldbookexcavationyear { get; set; }
        public string clusternumber { get; set; }
        public string shaftnumber { get; set; }
        public string burialidcomp { get; set; }
    }
}
