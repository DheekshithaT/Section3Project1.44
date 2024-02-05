using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SchoolApplication.Models
{
    public class Class
    {
        public int ClassId{ get; set; }
        public string Section {  get; set; }
        public int ClassStrength { get; set; }

    }
}