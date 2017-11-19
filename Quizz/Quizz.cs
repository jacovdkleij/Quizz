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
            var result = _questions.OrderBy(q => q.difficulty);
            foreach (Question _question in _questions)
            {
                ExecuteQuestion(_question);
            }
            printResults();
        }

        public void ExecuteQuizz(int value)
        {
            var _result = _questions.OrderBy(q => q.difficulty);
            IEnumerable<Question> result = _result.Where(q => q.difficulty == value);
            
            foreach (Question _question in result)
            {
                ExecuteQuestion(_question);
            }
            printResults();
        }

        public void ExecuteQuizz(String value)
        {
            var _result = _questions.OrderBy(q => q.difficulty);
            IEnumerable<Question> result = _result.Where(q => q.category == value);

            foreach (Question _question in result)
            {
                ExecuteQuestion(_question);
            }
            printResults();
        }

        public void ExecuteQuizz(String cat, int diff)
        {
            var _result = _questions.OrderBy(q => q.difficulty);
            IEnumerable<Question> result = _result.Where(q => q.category == cat && q.difficulty == diff);

            foreach (Question _question in result)
            {
                ExecuteQuestion(_question);
            }
            printResults();
        }

        private void ExecuteQuestion(Question q)
        {
            Console.WriteLine(q.question);
            if (q.isMultipleChoice())
            {
                char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
                int i = 0;
                foreach (string choiceAnswer in q.multipleChoiceAnswers)
                {
                    Console.WriteLine(alpha[i]+ ": " + choiceAnswer);
                    i++;
                }
            }
            String userAnswer = Console.ReadLine();
            userAnswers.Add(userAnswer);
            q.checkAnswer(userAnswer);
            Console.WriteLine("-----------");
        }
    }
}
