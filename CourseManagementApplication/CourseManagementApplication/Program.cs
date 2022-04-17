using System;
using static CourseManagementApplication.Group;

namespace CourseManagementApplication
{
    class Program:AllMethods
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Yeni qrup yarat");
            Console.WriteLine("2.Qruplarin siyahisini goster");
            Console.WriteLine("3.Qrup uzerinde duzelish etmek");
            Console.WriteLine("4.Qrupdaki telebelerin siyahisini goster");
            Console.WriteLine("5.Butun telebelerin siyahisini goster");
            Console.WriteLine("6.Telebe yarat\n");

            Console.Write("Secim edin : ");
            int userInput = Convert.ToInt32(Console.ReadLine());



            while (true)
            {
                if (userInput == 1) // 1.Yeni qrup yarat
                {
                    CreateGroup();
                    userInput = 111;
                    Console.Write("\nMenyudan secim edin : ");
                    userInput = Convert.ToInt32(Console.ReadLine());

                }
                else if (userInput == 2) //2.Qruplarin siyahisini goster
                {
                    ShowGroups();
                    userInput = 111;
                    Console.Write("\nMenyudan secim edin : ");
                    userInput = Convert.ToInt32(Console.ReadLine());
                }
                else if (userInput == 3) //3.Qrup uzerinde duzelish etmek
                {
                    EditGroup();
                    userInput = 111;
                    Console.Write("\nMenyudan secim edin : ");
                    userInput = Convert.ToInt32(Console.ReadLine());
                }
                else if (userInput == 4) //4.Qrupdaki telebelerin siyahisini goster
                {
                    ShowGroupStudents();
                    userInput = 111;
                    Console.Write("\nMenyudan secim edin : ");
                    userInput = Convert.ToInt32(Console.ReadLine());
                }
                else if (userInput == 5) //5.Butun telebelerin siyahisini goster
                {
                    ShowAllStudents();
                    userInput = 111;
                    Console.Write("\nMenyudan secim edin : ");
                    userInput = Convert.ToInt32(Console.ReadLine());
                }
                else if (userInput == 6) //6.Telebe yarat
                {
                    CreateStudent();
                    userInput = 111;
                    Console.Write("\nMenyudan secim edin : ");
                    userInput = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    Console.Write("\nSeciminiz menyuda tapilmadi, bir daha cehd edin : ");
                    userInput = Convert.ToInt32(Console.ReadLine());
                }
            }
        }

    }
}
