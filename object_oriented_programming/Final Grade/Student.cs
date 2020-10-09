using System;
using System.Collections.Generic;
using System.Text;

namespace Final_Grade
{
    class Student
    {
        public string Name;
        public double Grade1, Grade2, Grade3;

        public double AddGrade()
        {
            return Grade1 + Grade2 + Grade3;
        }

        public bool Approved()
        {
            if (AddGrade() >= 60.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public double PointsToGo()
        {
            if (Approved())
            {
                return 0.0;
            }
            else
            {
                return 60.0 - AddGrade();
            }
        }

    }
}
