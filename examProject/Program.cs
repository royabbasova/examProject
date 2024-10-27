
using examProject.Controller;
using examProject.Model;

AdminController adminController = new AdminController();
StudentController studentController = new StudentController();
QuestionController questionsController = new QuestionController();
CategoryController categoryController = new CategoryController();
first:
Console.WriteLine("1: Admin \n2: Telebe \n3: Exit");
int role = int.Parse(Console.ReadLine());

if (role == 1)
{
    var admin = new Admin { Name = "Admin", Surname = "Admin", Login = "admin", Password = "1234" };
login:
    Console.Write("Login: ");
    string login = Console.ReadLine();
    Console.Write("Password: ");
    string password = Console.ReadLine();

    if (login == admin.Login)
    {
        if (password == admin.Password)
        {
            opAdmin:
            Console.WriteLine("Admin emeliyyatlari: \n" +
                "1. Suallari goster\n" + 
                "2. Sual sil\n" + 
                "3. Telebe elave et\n" +
                "4. Telebe sil\n" +
                "5. Butun telebeleri goster\n" +
                "6. En basa donmek");
            int operation = int.Parse(Console.ReadLine());

            switch (operation)
            {
                case 1:
                    adminController.ShowAllQuestions();
                    goto opAdmin;

                case 2:
                    adminController.DeleteQuestion();
                    adminController.ShowAllQuestions();
                    goto opAdmin;

                case 3:
                    Console.Write("New student \nName: ");
                    string newName = Console.ReadLine();
                    Console.Write("Surname: ");
                    string newSurname = Console.ReadLine();
                    Console.Write("Login: ");
                    string newLogin = Console.ReadLine();
                    Console.Write("Password: ");
                    string newPassword = Console.ReadLine();

                    adminController.AddStudent(newName, newSurname, newLogin, newPassword);
                    goto opAdmin;

                case 4:
                    Console.Write("Silinmeli olan telebenin loginini daxil edin: ");
                    string loginToDelete = Console.ReadLine();

                    adminController.DeleteStudent(loginToDelete);
                    goto opAdmin;

                case 5:
                    adminController.ShowAllStudents();
                    goto opAdmin;

                case 6:
                    goto first;

            }
        }
        else
        {
            Console.WriteLine("Yalnisdir!");
            goto login;
        }
    }
    else
    {
        Console.WriteLine("Yalnisdir!");
        goto login;
    }

}
else if (role == 2)
{
    var student = new Student { Name = "Roya", Surname = "Abbasova", Login = "royabbasova", Password = "2486"};
    login:
    Console.Write("Login: ");
    string login = Console.ReadLine();
    Console.Write("Password: ");
    string password = Console.ReadLine();

    if (login == student.Login)
    {
        if (password == student.Password)
        {

            Console.WriteLine("Kateqoriya seçin: \n1. IT \n2. Marketing");
            int selectedCategory = int.Parse(Console.ReadLine());
            string category = selectedCategory == 1 ? "IT" : "Marketing";
            student.SelectedCategory = category;

            var questions = questionsController.GetQuestionsByCategory(category);

            if (questions.Count > 0)
            {
                studentController.AnswerQuestions(student, questions);
            }
            else
            {
                Console.WriteLine("Seçilen kateqoriyada sual tapilmadi.");
            }

        }
        else
        {
            Console.WriteLine("Yanlisdir!");
            goto login;
        }
    }
    else
    {
        Console.WriteLine("Yanlisdir!");
        goto login;
    }

}

else if (role == 3)
{
    Environment.Exit(0);
}

else
{
    Console.WriteLine("Secim yanlisdir");
    goto first;
}