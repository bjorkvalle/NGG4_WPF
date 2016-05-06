﻿using Quiz_WPFVersion.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_WPFVersion.Models
{
    public class Quiz 
    {
        public Quiz()
        {
            Questions = new Collection<Question>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int GScore { get; set; }
        public int VGScore { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public TimeSpan TimeLimit { get; set; }
        public bool ShowStudentResult { get; set; }
        public bool SentToAdmin { get; set; }
        public bool SentToStudent { get; set; }
        public int? UserId { get; set; }
        public User User { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
    }
}
