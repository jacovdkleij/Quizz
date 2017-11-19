using System;
using System.Collections.Generic;
using System.Text;

namespace Quizz
{
    class Quizz
    {
        List<Question> questions = new List<Question>();

        public void addQuestion(Question question)
        {
            questions.Add(question);
        }
    }
}
