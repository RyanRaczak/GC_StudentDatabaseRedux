using System;
using System.Collections.Generic;

namespace GC_StudentDatabaseRedux
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nWelcome to the Student Database");
            List<Student> Students = new List<Student>();
            Students = CreateStudents();
            bool userContinue = true;
            string input;
            int stuNum;
            while (userContinue)
            {
                input = GetInput("\n::MENU::\n1) Search Number\n2) Search Name\n3) Print Database\n4) Exit\n:: ");
                switch (input)
                {
                    case "1": //Searching by number
                        input = GetInput("\nPlease enter the students number: ");
                        if (int.TryParse(input, out stuNum))
                        {
                            if (stuNum >= 1 && stuNum <= Students.Count)
                            {
                                SearchStudentNum(Students, stuNum);
                            }
                            else
                            {
                                Console.WriteLine("\n~Invalid Input: Out of range~");
                            }
                        }
                        else
                        {
                            Console.WriteLine("\n~Invalid Input: Need whole number~");
                        }
                        break;
                    case "2": //Searching by name
                        input = GetInput("\nPlease enter the students name: ");
                        SearchStudentName(Students, input);
                        break;
                    case "3": //Print DB
                        Console.WriteLine("\n::DATABASE::");
                        for (int i = 0; i < Students.Count; i++)
                        {
                            Students[i].DisplayInfo();
                        }
                        break;
                    case "4": //Exit
                        userContinue = false;
                        Console.WriteLine("\n::Goodbye::");
                        break;
                    default: //Invalid input
                        Console.WriteLine("\n~Invalid Input: Pick a number from the menu~");
                        break;
                }
            }
        }
        public static void DisplayInfo(List<Student> students, int index)
        {
            string input;
            while (true)
            {
                input = GetInput("\nWhat would you like to learn about the student?" +
                    "\n1) Full Name" +
                    "\n2) Hometown" +
                    "\n3) Fav Food" +
                    "\n4) Fav Hobby" +
                    "\n5) Exit\n::");

                switch (input)
                {
                    case "1": //Full name
                        Console.WriteLine($"\nThe student's full name is " +
                                    $"{char.ToUpper(students[index].FirstName[0]) + students[index].FirstName.Substring(1)} " +
                                    $"{char.ToUpper(students[index].LastName[0]) + students[index].LastName.Substring(1)}");
                        break;
                    case "2": //Hometown
                        Console.WriteLine($"\nThe student's Hometown is {students[index].HomeTown}");
                        break;
                    case "3": //Fav Food
                        Console.WriteLine($"\nThe student's favorite food is {students[index].FavoriteFood}");
                        break;
                    case "4": //Fav Hobby
                        Console.WriteLine($"\nThe student's favorite hobby is {students[index].FavoriteHobby}");
                        break;
                    case "5": //EXIT
                        return;
                        break;
                    default:
                        Console.WriteLine("\n~Invalid Input: Pick a number from the menu~");
                        break;
                }
            }
        }
        public static void SearchStudentName(List<Student> students, string name)
        {
            bool stuFound = false;
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].LastName.ToLower().Equals(name.ToLower()))
                {
                    Console.WriteLine("\n~Student has been found~");
                    DisplayInfo(students, i);
                    stuFound = true;
                }

            }
            if (!stuFound)
            {
                Console.WriteLine("\n~Student not found~");
            }
        }
        public static void SearchStudentNum(List<Student> students, int stuNum)
        {
            bool stuFound = false;
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].StudentNum.Equals(stuNum))
                {
                    Console.WriteLine("\nStudent has been found.");
                    DisplayInfo(students, i);
                    stuFound = true;
                }
            }
            if (!stuFound)
            {
                Console.WriteLine("\n~Student not found~");
            }
        }
        public static string GetInput(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine().Trim();
        }
        static List<Student> CreateStudents()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student(1, "Rocky", "Balboa", "Detroit", "Eggs", "Boxing"));
            students.Add(new Student(2, "Jonny", "Smith", "Macomb", "Tacos", "Fishing"));
            students.Add(new Student(3, "Billy", "Jean", "Sterling Heights", "Cheese", "Singing"));
            students.Add(new Student(4, "Kelsey", "Jacobs", "San Francisco", "Beans", "Walking"));
            students.Add(new Student(5, "Justin", "Doe", "San Francisco", "Steak", "DJ"));
            students.Add(new Student(6, "Matt", "Declercq", "Sterling Heights", "Burritos", "Gaming"));
            students.Add(new Student(7, "Ryan", "Raczak", "Macomb", "Chicken", "Gaming"));
            students.Add(new Student(8, "Paul", "Weber", "Dandridge", "Ribs", "D&D"));
            students.Add(new Student(9, "Ray", "Batonia", "Utica", "Cigs", "Reading"));
            students.Add(new Student(10, "Michael", "Jackson", "Detroit", "Chicken", "Dancing"));
            return students;
        }
    }
}
