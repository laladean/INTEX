using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace INTEX.Models
{
    public partial class cranium
    {
        [Key]
        [Required]
        public long id { get; set; }
        public decimal? interobitalbreadth { get; set; }
        public decimal? maxnasalbreadth { get; set; }
        public decimal? basionnasion { get; set; }
        public decimal? interorbitalbreadth { get; set; }
        public decimal? nasionprosthionupper { get; set; }
        public decimal? nasoalphasubtense { get; set; }
        public decimal? basionbregmaheight { get; set; }
        public decimal? maxcraniumlength { get; set; }
        public decimal? interorbitalsubtense { get; set; }
        public decimal? basionprosthionlength { get; set; }
        public decimal? alphacore { get; set; }
        public decimal? midorbitalsubtense { get; set; }
        public decimal? maxcraniumbreadth { get; set; }
        public decimal? bizygomaticdiameter { get; set; }
        public decimal? midorbitalbreadth { get; set; }
    }
}
