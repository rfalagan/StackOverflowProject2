using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace StackOverflowProject.ViewModels
{
    public class CategoryViewModel
    {   
        [Required]
        public int CategoryID { get; set; }

        [Required]
        public string CategoryName { get; set; }


    }
}
