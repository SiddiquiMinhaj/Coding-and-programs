using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComarProj
{
    internal class sortbyValue
    {
        internal class Student : IComparable<Student>
        {

            public int Sid { get; set; }
            public string Name { get; set; }
            public int Class { get; set; }
            public float Marks { get; set; }

            public int CompareTo(Student other)
            {
                if (this.Sid > other.Sid)
                    return 1;
                else if (this.Sid < other.Sid)
                    return -1;
                else
                    return 0;
            }

            class compareStudent : IComparer<Student>
            {
                public int Compare(Student? x, Student? y)
                {
                    if (x.Marks > y.Marks)
                        return 1;
                    else if (x.Marks < y.Marks)
                        return -1;
                    else
                        return 0;
                }
            }

            class TestStorage
            {
                static void Main()
                {
                    Student s1 = new Student { Sid = 103, Name = "Ajay", Class = 10, Marks = 70.20f };
                    Student s2 = new Student { Sid = 105, Name = "Vijay", Class = 10, Marks = 90.20f };
                    Student s3 = new Student { Sid = 104, Name = "Shah", Class = 09, Marks = 80.20f };
                    Student s4 = new Student { Sid = 108, Name = "Davis", Class = 11, Marks = 88.23f };
                    Student s5 = new Student { Sid = 107, Name = "Raj", Class = 08, Marks = 60.22f };
                    Student s6 = new Student { Sid = 109, Name = "Sameer", Class = 11, Marks = 50.50f };



                    List<Student> students = new List<Student>() { s1, s2, s3, s4, s5, s6 };

                    compareStudent obj = new compareStudent();
                  
                    students.Sort(1,4, obj); //sort by index place, here it will sort from sid 105 to sid 107
              

                    foreach (Student s in students)
                    {
                        Console.WriteLine(s.Sid + " " + s.Name + " " + s.Class + " " + s.Marks + " ");

                    }
                    Console.ReadLine();
                }
            }

        }
    }
}
