using System;

namespace Quizz
{
    class Program
    {
        static void Main(string[] args)
        {
            Quizz quizz = new Quizz();
            Question q = new Question() { q = "test", answer = "test?"};
            quizz.addQuestion(q);
        }
    }
}
