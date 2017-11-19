using System;
using System.Collections.Generic;

namespace Quizz
{
    class Program
    {
        static void Main(string[] args)
        {
            Quizz quizz = new Quizz();
            Question question = new Question() { question = "test?", answer = "test", difficulty = 3 };
            quizz.AddQuestion(question);
            quizz.AddQuestion(question);
            List<String> multipleChoiceAnswersList = new List<string>();
            multipleChoiceAnswersList.Add("te");
            multipleChoiceAnswersList.Add("tes");
            multipleChoiceAnswersList.Add("test");
            multipleChoiceAnswersList.Add("t");
            Question multipleQuestion = new Question() { question = "test?", answer = "test", difficulty = 1, multipleChoiceAnswers = multipleChoiceAnswersList };
            quizz.AddQuestion(multipleQuestion);
            quizz.AddQuestion(multipleQuestion);
            quizz.ExecuteQuizz();
        }
    }
}
