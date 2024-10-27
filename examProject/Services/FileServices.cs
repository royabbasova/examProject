using examProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examProject.Services
{
    internal class FileServices
    {

        public List<Questions> LoadQuestionsFromFile()
        {
            return new List<Questions>
            {
            new Questions { Text = "Bulud texnologiyasi ne ucun istifade olunur?", 
                Answers = new List<string> { "A. Melumatlarin merkezi serverlerde saxlanilmasi ucun", 
                    "B. Yalniz sexsi komputerlerde melumatlarin qorunmasi ucun" }, 
                RightAnswerID = 0, Category = "IT" },
            new Questions { Text = "Internete qosulmaq ucun hansi cihaz esasen istifade olunur?", 
                Answers = new List<string> { "A. Modem", "B. Printer" }, 
                RightAnswerID = 1, Category = "IT" },
            new Questions { Text = "RAM hansi meqsedle istifade olunur?",
                Answers = new List<string> { "A. Uzun muddetli yaddas ucun", "B. Muveqqeti yaddas ucun" },
                RightAnswerID = 1, Category = "IT" },
            new Questions { Text = "Marketinqde \"hedef auditoriya\" ne demekdir?", 
                Answers = new List<string> { "A. Mehsul ve ya xidmetin teqdim edildiyi xususi qrup", 
                    "B. Butun movcud musteriler" }, 
                RightAnswerID = 0, Category = "Marketing" },
            new Questions { Text = "SWOT tehlilinde \"T\" hansi menani dasiyir?", 
                Answers = new List<string> { "A. Tehluke (Threat)", "B. Texnologiya" }, 
                RightAnswerID = 1, Category = "Marketing" },
            new Questions { Text = "Mehsulun qiymetini mueyyen etmekde hanse amil daha vacibdir?", 
                Answers = new List<string> { "A. Musterinin istekleri", "B. Reqabet muhiti" }, 
                RightAnswerID = 0, Category = "Marketing" }
            };
        }

        public void SaveQuestionsToFile(List<Questions> questions)
        {
            Console.WriteLine("Suallar fayla yazildi.");
        }

    }
}
