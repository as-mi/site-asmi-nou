using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ASMI.Models
{
    public class Quiz
    {
        public List<QuizQuestion> questions { get; set; }

        [Required]
        public List<string> answers { get; set; }
    }
}
