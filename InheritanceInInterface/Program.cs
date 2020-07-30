using System;

namespace InheritanceInInterface
{
    public interface StudentA
    {
        void MedicalStudent();
    }
    public interface StudentB : StudentA
    {
        void EngineeringStudent();
        void CommerceStudent();
    }
    class Student : StudentB
    {
        public void MedicalStudent()
        {
            Console.WriteLine("Compulsary Bia");
        }
        public void EngineeringStudent()
        {
            Console.WriteLine("Compulsary Mathmatics");
        }
        public void CommerceStudent()
        {
            Console.WriteLine("Compulsary Economic");
        }

        class Program
        {
            static void Main(string[] args)
            {
                Student obj = new Student();
                obj.MedicalStudent();
                obj.EngineeringStudent();
                obj.CommerceStudent();
            }
        }
    }
}
