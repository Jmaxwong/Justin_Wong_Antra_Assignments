﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models
{
    public class SubmissionRequestModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter your email")]
        [StringLength(512)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter your First Name")]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter your Last Name")]
        [StringLength(50)]
        public string LastName { get; set; }

    }
}
