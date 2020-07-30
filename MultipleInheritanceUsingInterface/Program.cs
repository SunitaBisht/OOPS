using System;
using System.Collections;

namespace MultipleInheritanceUsingInterface
{
    interface Collage
    {
        void languages();
    }
    // Parent class 1 
    class CollagePG : Collage
    {
        public void languages()
        {
            ArrayList ArList = new ArrayList();

            ArList.Add("C#");
            ArList.Add("ASP.NET");
            ArList.Add("ADO.NET");

            Console.WriteLine("This Type of languages provided by Collages:");
            foreach (var element in ArList)
            {
                Console.WriteLine(element);
            }
        }


        interface Institute
        {
            void Course();
        }
        // Parent class 2 
        class InstitutePG : Institute
        {
            public void Course()
            {
                ArrayList ArList = new ArrayList();

                ArList.Add("c language");
                ArList.Add("ASP.NET CORE");
                ArList.Add("c# MVC");

                Console.WriteLine("This type cources provided by Institute");
                foreach (var element in ArList) 
                {
                    Console.WriteLine(element);
                }
            }
        }

        //Child Class
        class University : Collage, Institute
        {
            CollagePG obj1 = new CollagePG();
            InstitutePG obj2 = new InstitutePG();

            public void languages()
            {
                obj1.languages();
            }
            public void Course()
            {
                obj2.Course();
            }
        }

        //Drive Class
        class Program
        {

            static void Main(string[] args)
            {
                University obj = new University();
                obj.languages();
                obj.Course();
            }
        }
    }
}
