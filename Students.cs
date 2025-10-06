using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Based_Student_Management_System
{
    internal class Students
    {
        private int _grades;
        private int _age;
        public int Age {
            get { return _age; }
            set
            {
                if (value < 0)
                {
                    _age = 0;
                }
                else
                {
                    _age = value;
                }

            }
        }
        public string Name { get; set; }
        public int Grades
        {
            get { return _grades; }
            set
            {
                if (value < 0)
                {
                    _grades = 0;

                }
                else if (value > 100)
                {
                    _grades = 100;
                }
                else
                {
                    _grades = value;
                }
            }
        }
        public Students(int age,string name,int grades)
        {
            Age = age;
            Name = name;
            Grades = grades;
        }

    }
}
