using System;
using System.Collections.Generic;
using System.Text;

namespace GC_StudentDatabaseRedux
{
    class Student
    {
        public int StudentNum { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string HomeTown { get; set; }
        public string FavoriteFood { get; set; }
        public string FavoriteHobby { get; set; }

        public Student(int stuNum, string fname, string lname, string home, string food, string hobby)
        {
            this.StudentNum = stuNum;
            this.FirstName = fname;
            this.LastName = lname;
            this.HomeTown = home;
            this.FavoriteFood = food;
            this.FavoriteHobby = hobby;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Number: {StudentNum}\nName: {FirstName} {LastName}\nHometown: {HomeTown}" +
                $"\nFavorite Food: {FavoriteFood}\nFavorite Hobby: {FavoriteHobby}");
        }
    }
}
