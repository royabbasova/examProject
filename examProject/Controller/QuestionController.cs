using examProject.Model;
using examProject.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examProject.Controller
{
    internal class QuestionController
    {
        public List<Questions> QuestionList = new List<Questions>();
        private FileServices fileService = new FileServices();

        public QuestionController()
        {
            QuestionList = fileService.LoadQuestionsFromFile();
        }

        public void DeleteQuestion(Questions question)
        {
            QuestionList.Remove(question);
            Console.WriteLine("Question deleted successfully!");
        }

        public void ShowAllQuestions()
        {
            if (QuestionList.Count == 0)
            {
                Console.WriteLine("Sual yoxdur.");
                return;
            }

            for (int i = 0; i < QuestionList.Count; i++)
            {
                var question = QuestionList[i];
                Console.WriteLine($"{i+1}. {question.Text}");
                for (int j = 0; j < question.Answers.Count; j++)
                {
                    Console.WriteLine($"  {j + 1}. {question.Answers[j]}");
                }
                Console.WriteLine($"Kateqoriya: {question.Category}\n");
            }
        }

        public List<Questions> GetQuestionsByCategory(string category)
        {
            var filteredQuestions = QuestionList.Where(q => q.Category == category).ToList();

            if (filteredQuestions.Count == 0)
            {
                Console.WriteLine($"'{category}' kateqoriyasında sual tapılmadı.");
            }

            return filteredQuestions;
        }

    }
}
