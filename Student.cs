using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEncapApp
{
    internal class Student
    {
        public int rollNo;
        public string name;
        public double cgpa;

        public int RollNo
        {
            get { return rollNo; }
            set { rollNo = value > 0 ? value: 0; }
        }
        //  to ensure the name is at least 5 characters long
        public string Name
        {
            get { return name; }
            set { name = value.Length >= 5 ? value : string.Empty; }
        }
        //  to ensure the CGPA is between 1 and 10
        public double Cgpa
        {
            get { return cgpa; }
            set { cgpa = (value >= 1 && value <= 10) ? value : 0; }
        }
        //  method to calculate percentage from CGPA
        public double GetPercentage()
        {
            return Cgpa * 10;
        }
        //  override ToString method to display student details
        public override string ToString()
        {
            return $"Roll No: {RollNo}, Name: {Name}, CGPA: {Cgpa}, Percentage: {GetPercentage()}%";
        }
    }
}
