using System;

namespace Quizz
{
    class Program
    {
        static void Main(string[] args)
        {
            Quizz quizz = new Quizz();
            Question question = new Question() { question = "test?", answer = "test"};
            quizz.AddQuestion(question);
            quizz.AddQuestion(question);
            quizz.AddQuestion(question);
            quizz.ExecuteQuizz();
        }
    }
}
