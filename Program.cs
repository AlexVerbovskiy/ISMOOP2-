using System;
using lib1;
using lib2;
using lib3;
using lib4;
using lib5;
using System.Text;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Human Alex= new Human( "Alex", "Carnell", 03, 02, 2001);
            Console.WriteLine("Клас Human\nІм`я: {0}\nПрізвіще: {1}\nДата народження: {2}\n", Alex.NameHuman, Alex.SecondNameHuman, Alex.BirthdayDateHuman);
            Graduate Bill = new Graduate("Bill", "Morton", "23.03.2003", 185,11, "school_27");
            Console.WriteLine("Клас Graduate\nІм`я: {0}\nПрізвіще: {1}\nДата народження: {2}\nБал ЗНО: {3}\nБал документа: {4}\nОсвітній заклад: {5}\n", Bill.NameHuman, Bill.SecondNameHuman, Bill.BirthdayDateHuman, Bill.ZNOPointsGraduate, Bill.DocPointsGraduate,Bill.SchoolNameGraduate);
            Student TomNorton = new Student("Tom", "Norton", "17.07.2002", 1, "ІПЗ-20-1", "ФІКТ", "Житомирська політехніка");
            Console.WriteLine("Клас Student\nІм`я: {0}\nПрізвіще: {1}\nДата народження: {2}\nКурс: {3}\nГрупа: {4}\nФакультет: {5}\nУніверситет: {6}\n", TomNorton.NameHuman, TomNorton.SecondNameHuman, TomNorton.BirthdayDateHuman, TomNorton.CourseStudent, TomNorton.GroupStudent,TomNorton.FacultyStudent, TomNorton.UniversityStudent);
            Professor ProfessorAlbert = new Professor("Albert", "Lindsay", 15, 04, 1973, "Старший викладач кафедри", "ІПЗ", "Житомирська політехніка");
            Console.WriteLine("Клас Professor\nІм`я: {0}\nПрізвіще: {1}\nДата народження: {2}\nПосада: {3}\nКафедра: {4}\nОсвітній заклад: {5}\n", ProfessorAlbert.NameHuman, ProfessorAlbert.SecondNameHuman, ProfessorAlbert.BirthdayDateHuman, ProfessorAlbert.PosadaProfessor, ProfessorAlbert.CathedraProfessor, ProfessorAlbert.UniversityProfessor);
            LibraryUser AgathaWade = new LibraryUser("Agatha", "Wade", "17.07.2002",1734, "5.03.2019", 700);
            Console.WriteLine("Клас LibraryUser\nІм`я: {0}\nПрізвіще: {1}\nДата народження: {2}\nНомер читацького квитка: {3}\nДата видачі: {4}\nЧитацький внесок: {5}\n", AgathaWade.NameHuman, AgathaWade.SecondNameHuman, AgathaWade.BirthdayDateHuman, AgathaWade.NumberLibraryUser, AgathaWade.DateVidachiLibraryUser, AgathaWade.VnesokLibraryUser);
            Alex.NameHuman = "Alexandr";
            Bill.SchoolNameGraduate = "school_5";
            TomNorton.CourseStudent = 2;
            ProfessorAlbert.UniversityProfessor = "Univetsity Franka";
            AgathaWade.SecondNameHuman = "Askvit";
            Alex.ShowInfo();
            Bill.ShowInfo();
            TomNorton.ShowInfo();
            ProfessorAlbert.ShowInfo();
            AgathaWade.ShowInfo();
        }
    }
}
