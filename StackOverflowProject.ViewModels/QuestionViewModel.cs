using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace StackOverflowProject.ViewModels
{
    public  class QuestionViewModel
    {
        public int QuestionID { get; set; }
        public string QuestionName { get; set; } 
        public DateTime QuestionDateAndTime { get; set; }

        public int UserID { get; set; }

        public int CategoryID { get; set; }

        public int VotesCount { get; set; }

        public int AnswersCount { get; set; }

        public int ViewsCount {  get; set; }



        // user details that this question belongs to

        public UserViewModel User { get; set;  }

        // Category Details
        public CategoryViewModel Category { get; set; }

        // Multiples anwers per question
        public virtual List<AnswerViewModel> Answers { get; set; }

    }
}
