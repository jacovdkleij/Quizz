using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quizz
{
    class Quizz
    {
        List<Question> _questions = new List<Question>();
        List<String> userAnswers = new List<string>();
        int correctAnswers = 0;

        public void AddQuestion(Question question)
        {
            _questions.Add(question);
        }

        private void printResults()
        {
            Console.WriteLine("Results:");
            int i = 0;
            foreach (Question _question in _questions)
            {
                if (!_question.Equals(_questions.First()))
                {
                    Console.WriteLine("-----------");
                }

                Console.WriteLine("Question: " + _question.question);
                Console.WriteLine("Answer: " + _question.answer);
                Console.WriteLine("Your answer: " + userAnswers[i]);
                i++;
            }
            Console.WriteLine("Correct answers: "+ correctAnswers + "/" + _questions.Count);
            Console.ReadLine();
        }

        public void ExecuteQuizz()
        {
            foreach (Question _question in _questions)
            {
                ExecuteQuestion(_question);
            }
            printResults();
        }

        public void ExecuteQuizzByDifficulty()
        {
            var result = _questions.OrderBy(q => q.difficulty);

            foreach (var _question in result)
            {
                ExecuteQuestion(_question);
            }
            printResults();
        }

        public void ExecuteQuizzWhere(int value)
        {
            IEnumerable<Question> result = _questions.Where(q => q.difficulty == value);
            
            foreach (Question _question in result)
            {
                ExecuteQuestion(_question);
            }
            printResults();
        }

        public void ExecuteQuizzWhere(String value)
        {
            IEnumerable<Question> result = _questions.Where(q => q.category == value);

            foreach (Question _question in result)
            {
                ExecuteQuestion(_question);
            }
            printResults();
        }

        public void ExecuteQuestion(Question q)
        {
            Console.WriteLine(q.question);
            String userAnswer = Console.ReadLine();
            userAnswers.Add(userAnswer);
            if (userAnswer.Equals(q.answer))
            {
                correctAnswers++;
            }
            Console.WriteLine("-----------");
        }
    }
}
