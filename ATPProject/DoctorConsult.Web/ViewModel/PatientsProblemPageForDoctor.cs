﻿using System.ComponentModel.DataAnnotations;
using System.Web;

namespace DoctorConsult.Core.Entity.ViewModel
{
    public class PatientsProblemPageForDoctor
    {
        [Required]
        [Display(Name = "Problem Summary: ")]
        [StringLength(200, ErrorMessage = "Maximum 200 words")]
        public string ProblemSummary { get; set; }
        [Required]
        [Display(Name = "Problem Details: ")]
        public string ProblemDetails { get; set; }
        [Display(Name = "Uploaded Reports ")]
        public HttpPostedFileBase filePath { get; set; }
        [Display(Name = "Previos Doctor's Prescriptions ")]
        public HttpPostedFileBase PreviousProblemFile { get; set; }
        [Display(Name = "Previous Reports ")]
        public HttpPostedFileBase PreviousProblemReportFile { get; set; }
    }
}
