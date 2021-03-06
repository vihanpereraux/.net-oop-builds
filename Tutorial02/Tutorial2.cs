using System;

//Tutorial paper asked to put it
using System.Collections.Generic;

namespace Tutorial02
{
    class Tutorial2
    {
        static void Main(string[] args)
        {
            //Question 1 | 2 

            /*Student student1 = new Student();
            Professor professor1 = new Professor();
            student1.name = "Vihan";
            Console.WriteLine(student1.name);
            Console.ReadLine();*/

            /*List<String> subjects = new List<String>() { "Maths", "Science", "English" };
            List<int> codes = new List<int>() { 1, 2, 3, 5 };

            Professor professor1 = new Professor("Dilan", "Perera", subjects);
            Student student1 = new Student("Vihan", "Perera", codes);*/

            Tutorial2 q4 = new Tutorial2();
            q4.question04();

            Tutorial2 q7 = new Tutorial2();
            q7.question07();

            Tutorial2 q10 = new Tutorial2();
            q10.question09();
        }

        //Question 4
        public void question04()
        {
            Tutorial2 t2 = new Tutorial2();

            //Student object - t2
            Student student2 = new Student();
            student2.name = "Yvonne";
            student2.lastName = "Perera";
            List<int> codes2 = new List<int> { 111, 222, 333 };
            student2.courseCodes = codes2;

            t2.outputInformation(student2);
            //Console.ReadLine();

            //Professor object - t2
            Professor professor2 = new Professor();
            professor2.name = "Rohan";
            professor2.lastName = "Lekamge";
            List<String> subjects2 = new List<String> { "Maths", "Science", "English" };
            professor2.teachesSubjects = subjects2;

            t2.outputInformation(professor2);
            Console.ReadLine();
        }

        //Question 7
        public void question07()
        {
            Student student3 = new Student();
            student3.name = "Yvonne";
            student3.lastName = "Perera";
            List<int> codes3 = new List<int> { 111, 222, 333 };
            student3.courseCodes = codes3;
            outputInformation02(student3);

            Professor professor3 = new Professor();
            professor3.name = "Rohan";
            professor3.lastName = "Lekamge";
            List<String> subjects3 = new List<String> { "Maths", "Science", "English" };
            professor3.teachesSubjects = subjects3;
            outputInformation02(professor3);
            Console.ReadLine();
        }

        //Question 9 - Input
        public void question09()
        {
            Student student4 = null;
            outputInformation03(student4);
            Console.ReadLine();
        }
        
      
        //Question 3 
        public void outputInformation(object person)
        {
            if(person is Student)
            {
                Student student = (Student)person;
                Console.WriteLine($"Student {student.name} {student.lastName} is enrolled for courses {String.Join<int>(", ", student.courseCodes)}");
                //Console.ReadLine();
            }

            if(person is Professor)
            {
                Professor professor = (Professor)person;
                Console.WriteLine($"Professor {professor.name} {professor.lastName} teaches {String.Join<string>(", ", professor.teachesSubjects)}");
                //Console.ReadLine();
            }
        }

        //Question 6 | 7
        public void outputInformation02(object person)
        {
            if (person is Student student)
            {
                Console.WriteLine($"Student {student.name} {student.lastName} is enrolled for courses {String.Join<int>(", ", student.courseCodes)}");
            }

            if(person is Professor professor)
            {
                Console.WriteLine($"Professor {professor.name} {professor.lastName} teaches {String.Join<string>(", ", professor.teachesSubjects)}");
            }
        } 

        //Question 9 - Method
        public void outputInformation03(object person)
        {
            if(person is null)
            {
                Console.WriteLine($"Object {nameof(person)} is null");
            }
        }

        //Question 12 | 13 | 14 - Switch Case Method
        public void outputInformation04(object person)
        {
            switch (person)
            {
                case Professor professor:
                    Console.WriteLine($"Professor {professor.name} {professor.lastName} " +
                        $"teaches {String.Join<string>(", ", professor.teachesSubjects)}");
                break;

                case Student student:
                    Console.WriteLine($"Student {student.name} {student.lastName} enrolled for courses " +
                        $"{String.Join<int>(", ", student.courseCodes)}");
                break;

                default:
                    Console.WriteLine("Unkown objected detected");
                break;
            }
        }

        //Question 15 - Switch Case (when) Method
        public void outputInformation05(object person)
        {
            switch (person)
            {
                case Student student when student.courseCodes.Contains(203):
                    Console.WriteLine($"Student {student.name} {student.lastName} is enrolled for course 204");
                break;

                case Student student:
                    Console.WriteLine($"Student {student.name} {student.lastName} is enrolled for courses " +
                        $"{String.Join<int>(", ", student.courseCodes)}");
                break;

                case Professor professor:
                    Console.WriteLine($"Professor {professor.name} {professor.lastName} " +
                        $"teaches {String.Join<string>(", ", professor.teachesSubjects)}");
                break;

                default:
                    Console.WriteLine("Unknown objected detected");
                break;
            }
        }

        //Question 16 - Switch Case (when & null) Method
        public void outputInformation06(object person)
        {
            switch (person)
            {
                case Student student when student.courseCodes.Contains(203):
                    Console.WriteLine($"Student {student.name} {student.lastName} is enrolled for course 204");
                    break;

                case Student student:
                    Console.WriteLine($"Student {student.name} {student.lastName} is enrolled for courses " +
                        $"{String.Join<int>(", ", student.courseCodes)}");
                    break;

                case Professor professor:
                    Console.WriteLine($"Professor {professor.name} {professor.lastName} " +
                        $"teaches {String.Join<string>(", ", professor.teachesSubjects)}");
                    break;

                case null:
                    Console.WriteLine($"Object {nameof(person)} is null");
                break;

                default:
                    Console.WriteLine("Unknown objected detected");
                break;
            }
        }

    }
}
