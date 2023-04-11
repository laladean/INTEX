using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace INTEX.Models
{
    public partial class bodyanalysischart
    {
        [Key]
        [Required]
        public string squarenorthsouth { get; set; }
       
        public string northsouth { get; set; }
       
        public string squareeastwest { get; set; }
       
        public string eastwest { get; set; }
       
        public string area { get; set; }
       
        public int burialnumber { get; set; }
     
        public string dateofexamination { get; set; }
        public int? preservationindex { get; set; }
        public string haircolor { get; set; }
        public string observations { get; set; }
        public string robust { get; set; }
        public string supraorbitalridges { get; set; }
        public string orbitedge { get; set; }
        public string parietalbossing { get; set; }
        public string gonion { get; set; }
        public string nuchalcrest { get; set; }
        public string zygomaticcrest { get; set; }
        public string sphenooccipitalsynchondrosis { get; set; }
        public string lamboidsuture { get; set; }
        public string squamossuture { get; set; }
        public string toothattrition { get; set; }
        public string tootheruption { get; set; }
        public string tootheruptionageestimate { get; set; }
        public string ventralarc { get; set; }
        public string subpubicangle { get; set; }
        public string sciaticnotch { get; set; }
        public string pubicbone { get; set; }
        public string medialipramus { get; set; }
        public string femur { get; set; }
        public string humerus { get; set; }
        public string femurheaddiameter { get; set; }
        public string humerusheaddiameter { get; set; }
        public decimal? femurlength { get; set; }
        public decimal? humeruslength { get; set; }
        public string osteophytosis { get; set; }
        public string cariesperiodontaldisease { get; set; }
        public string notes { get; set; }
    }
}
