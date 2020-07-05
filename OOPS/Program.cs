using System;

namespace ClassAndConstructorExample
{
    public class Student
    {
        String Name;
        int Age;
        int RollNumber;
        String Standard;

        public Student(String Name, int Age, int RollNumber, String Standard)
        {
            this.Name = Name;
            this.Age = Age;
            this.RollNumber = RollNumber;
            this.Standard = Standard;
        }

        public String getName()
        {
            return Name;
        }
        public int getAge()
        {
            return Age;
        }
        public int getRollNumber()
        {
            return RollNumber;
        }
        public String getStandard()
        {
            return Standard;
        }

        public String toString()
        {
            return ("Hii My name is " + this.getName() + " My Age is " + this.getAge() + " and my RollNumber is " + this.getRollNumber() + " and i study in " + this.getStandard() + " Standard");

        }
        static void Main(string[] args)
        {
            Student std = new Student("Sunita", 23, 40, "11th");
            Console.WriteLine(std.toString());
            Console.ReadLine();
        }
    }
}
