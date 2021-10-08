using System;
using System.Collections.Generic;
using System.Text;

namespace Tutorial02
{
    class Student : Person
    {
        public List<int> courseCodes { get; set; }
    }
}






/*class Student
{
    //Student properties
    public String studentName;
    public String studentLastName;
    public List<int> CourseCodes;

    //Methods
    public Student() { }

    public Student(String studentName, String studentLastName, List<int> CourseCodes)
    {
        this.studentName = studentName;
        this.studentLastName = studentLastName;
        this.CourseCodes = CourseCodes;
    }

    public void getName()
    {
        Console.WriteLine(studentName);
    }
    public void setName(String name)
    {
        this.studentName = name;
    }

    public void getLastName()
    {
        Console.WriteLine(studentLastName);
    }
    public void setLastName(String lastName)
    {
        this.studentLastName = lastName;
    }

    public void getCourseCodes()
    {
        for (int i = 0; i < CourseCodes.Count; i++)
        {
            Console.WriteLine(CourseCodes[i]);
        }
    }
}*/
