using examProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examProject.Controller
{
    internal class StudentController
    {

        private List<Student> StudentsList = new List<Student>();

        public void AddStudent(Student student)
        {
            StudentsList.Add(student);
            Console.WriteLine("Student added successfully!");
        }

        public void DeleteStudent(Student student)
        {
            StudentsList.Remove(student);
            Console.WriteLine("Student deleted successfully!");
        }

        public Student GetStudentById(string login)
        {
            return StudentsList.FirstOrDefault(s => s.Login == login);
        }

        public void ShowAllStudents()
        {
            foreach (var student in StudentsList)
            {
                student.ShowInfo();
            }
        }

        public void AnswerQuestions(Student student, List<Questions> questions)
        {
            if (questions == null || questions.Count == 0)
            {
                Console.WriteLine("Sual yoxdur.");
                return;
            }

            int score = 0;
            for (int i = 0; i < questions.Count; i++)
            {
                var question = questions[i];
                Console.WriteLine($"{i + 1}. Sual: {question.Text}");

                for (int j = 0; j < question.Answers.Count; j++)
                {
                    Console.WriteLine($"  {j + 1}. {question.Answers[j]}");
                }

                Console.Write("Cavabinizi secin (1 ve ya 2): ");
                if (int.TryParse(Console.ReadLine(), out int answer) && answer > 0 && answer <= question.Answers.Count)
                {
                    if (answer - 1 == question.RightAnswerID)
                    {
                        score++;
                        Console.WriteLine("Duzgun cavab!");
                    }
                    else
                    {
                        Console.WriteLine("Sehv cavab.");
                    }
                }
                else
                {
                    Console.WriteLine("Bele bir cavab secimi yoxdur.");
                }

                Console.WriteLine();
            }

            student.Score = score;
            Console.WriteLine($"Sizin umumi neticeniz: {student.Score}/{questions.Count}");
        }
    }

    
}
