
namespace StudentLibrary
{
    class Student
    {
        // Variables
        private int studentId;
        private String name;
        private int age;
        private static int studentCount = 0;

        // Public properties
        public int StudentId
        {
            get { return studentId; }
            private set { studentId = value; } // Private setter makes it read-only
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public static int StudentCount
        {
            get { return studentCount; }
            private set { studentCount = value; }
        }
        public Student()
        {
            name = "John Doe";
            age = 16;
            studentId = studentCount++;
        }
        public Student(int name, int age)
        {
            studentId = studentCount++;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Student name: {Name}");
            Console.WriteLine($"Student age: {Age}");
            Console.WriteLine($"Student ID: {StudentId}");
        }
    }
}
