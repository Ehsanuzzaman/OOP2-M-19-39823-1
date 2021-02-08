using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
   
         class Student
        {
            private string name;
            private string id;
            private string department;
            private float cgpa;

            public void  ShowInfo()
            {
                Console.WriteLine("Name: " + name);
                Console.WriteLine("ID: " + id);
                Console.WriteLine("Department: " + department);
                Console.WriteLine("CGPA: " + cgpa);
            }

            public void SetName(string name)
            {
                this.name = name;
            }
            public void SetID(string id)
            {
                this.id = id;
            }
            public void SetDepartment(string department)
            {
                this.department = department;
            }
            public void SetCGPA(float cgpa)
            {
                this.cgpa = cgpa;
            }

            public string getName()
            {
                return name;
            }
            public string getID()
            {
                return id;
            }
            public string getDepartment()
            {
                return department;
            }
            public float getCGPA()
            {
                return cgpa;
            }
        }

        }
    }
}
