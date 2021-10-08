using System;
using System.Collections.Generic;
using System.Text;

namespace Tutorial02
{
    class Professor : Person
    {
        public List<String> teachesSubjects { get; set; }
    }
}






/*class Professor
{
    //Professor properties
    public String profName;
    public String profLastName;
    public List<String> teachesSubjects;

    //Professor methods
    public Professor() { }

    public Professor(String profName, String profLastName, List<String> teachesSubjects)
    {
        this.profName = profName;
        this.profLastName = profLastName;
        this.teachesSubjects = teachesSubjects;
    }

    public void getName()
    {
        Console.WriteLine(profName);
    }
    public void setName(String name)
    {
        this.profName = name;
    }

    public void getLastName()
    {
        Console.WriteLine(profLastName);
    }
    public void setLastName(String lastName)
    {
        this.profLastName = lastName;
    }

    public void getCourseCodes()
    {
        for (int i = 0; i < teachesSubjects.Count; i++)
        {
            Console.WriteLine(teachesSubjects[i]);
        }
    }

}*/
