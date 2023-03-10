using BigSchool.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BigSchool.ViewModels
{
    public class CoursesViewModel
    {
        [Required(ErrorMessage = "Bắt buộc nhập")]
        public string Place { get; set; }
        [Required(ErrorMessage = "Bắt buộc nhập")]
        [FutureDate]
        public string Date { get; set; }
        [Required(ErrorMessage = "Bắt buộc nhập")]
        [ValidTime]
        public string Time { get; set; }
        [Required(ErrorMessage = "Bắt buộc nhập")]
        public byte Category { get; set; }
        public IEnumerable<Category> Categoies { get; set; }
        public DateTime GetDateTime() 
        { 
            return DateTime.Parse(string.Format("{0} {1}", Date, Time)); 
        }  
    }
}