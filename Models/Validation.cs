using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ClientValidation.Models
{
    public class Validation
    {
        //entered data validtions//
       [Required(ErrorMessage = "Please enter Name.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter Phone No.")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$",
                   ErrorMessage = "Entered phone format is not valid.")]
        public string Phone { get; set; }

         [Required(ErrorMessage = "Please enter Phone No.")]
         //[RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]

         [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                            @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                            @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$",
                            ErrorMessage = "Email is not valid")]
        public string Email { get; set; }

        [Required(ErrorMessage = "- Select item -")]
         public string Gender { get; set; }

        public string Upload_files { get; set; }
    }
}