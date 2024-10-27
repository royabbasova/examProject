using examProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examProject.Controller
{
    internal class AdminController
    {

        private List<Admin> AdminsList = new List<Admin>();
        private QuestionController questionsController = new QuestionController();
        public List<Questions> QuestionList = new List<Questions>();

        public void ShowAllQuestions()
        {
            questionsController.ShowAllQuestions();
        }

        public void DeleteQuestion()
        {
            questionsController.ShowAllQuestions(); 
            Console.WriteLine("Silinmeli olan sualin indeksini daxil edin:");
            int index = int.Parse(Console.ReadLine());

            if (index >= 0 && index < questionsController.QuestionList.Count)
            {
                Questions questionToDelete = questionsController.QuestionList[index-1];
                questionsController.DeleteQuestion(questionToDelete);
                Console.WriteLine("Sual silindi.");
            }
            else
            {
                Console.WriteLine("Yanlis indeks daxil edilib!");
            }
        }

        public void ViewStudentResults(StudentController studentController)
        {
            studentController.ShowAllStudents();
        }


        private List<Student> StudentList;

        public AdminController()
        {
            StudentList = new List<Student>();
        }

        public void AddStudent(string name, string surname, string login, string password)
        {
            var student = new Student { Name = name, Surname = surname, Login = login, Password = password };
            StudentList.Add(student);
            Console.WriteLine("Telebe elave olundu.");
        }

        public void DeleteStudent(string login)
        {
            var student = StudentList.FirstOrDefault(s => s.Login == login);
            if (student != null)
            {
                StudentList.Remove(student);
                Console.WriteLine("Telebe silindi.");
            }
            else
            {
                Console.WriteLine("Bu login ile telebe tapilmadi.");
            }
        }

        public void ShowAllStudents()
        {
            Console.WriteLine("Butun telebeler:");
            foreach (var student in StudentList)
            {
                Console.WriteLine($"Name: {student.Name}\n" +
                    $"Surname: {student.Surname}\n" +
                    $"Login: {student.Login}\n" +
                    $"Password: {student.Password}");
            }
        }

    }
}
