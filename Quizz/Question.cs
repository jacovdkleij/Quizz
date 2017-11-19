using System;
using System.Collections.Generic;
using System.Linq;

namespace Quizz
{
    class Question
    {
        public String question { get; set; }
        public String answer { get; set; }
        public int difficulty { get; set; }
        public String category { get; set; }
        public List<String> multipleChoiceAnswers { get; set; }

        public Boolean isMultipleChoice()
        {
            return multipleChoiceAnswers != null;
        }

        public Boolean checkAnswer(String userAnswer)
        {
            if (!isMultipleChoice())
            {
                if (userAnswer.Equals(answer))
                {
                    return true;
                }
            }
            else
            {
                int i = userAnswer.ToUpper().First() - 64;
                if (multipleChoiceAnswers[i].Equals(answer))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
