using System;
using System.Collections.Generic;

namespace WebAPIProj.Models
{
    public partial class Student
    {
        public int SId { get; set; }
        public string? SFname { get; set; }
        public string? SLname { get; set; }
        public string? SEmailId { get; set; }
        public int? SMobileNo { get; set; }
        public string? SAddress { get; set; }
        public string? SClass { get; set; }
        public string? SDiv { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
