using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace INTEX.Models
{
    public partial class artifactfagelgamousregisterburialmain
    {
        [Key]
        [Required]
        public long mainartifactfagelgamousregisterid { get; set; }
       
        public long mainburialmainid { get; set; }
    }
}
