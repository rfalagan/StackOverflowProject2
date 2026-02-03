using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace StackOverflowProject.ViewModels
{
    public class EditAnswerViewModel
    {
        [Required]
        public int AnswerID { get; set; }
        
        [Required]
        public string AnswerText { get; set; }
        
        [Required]
        public DateTime AnseDateAndTime { get; set; }
       
        [Required]
        public int UserID { get; set; }
      
        [Required]
        public int QestionID { get; set;  }

        [Required]
        public int VotesCount { get; set; }

        public virtual QuestionViewModel Question { get; set; }








    }
}
