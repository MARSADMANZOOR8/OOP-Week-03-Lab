using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class student
    {
        public student(string n, float matric, float inter, float ecat, float agggegrate)
        {
            name = n;
            matric_marks = matric;
            fsc_marks = inter;
            ecat_marks = ecat;
            aggegrate = agggegrate;
        }
       
        public string name;
        public float matric_marks;
        public float fsc_marks;
        public float ecat_marks;
        public float aggegrate;
    }
      
}
