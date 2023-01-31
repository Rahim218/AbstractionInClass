using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Student
    {
        static int _totalCount;
        public Student()
        {
            _totalCount++;
            No = _totalCount;
        }
        public string FullName;
        public int Point;

        public int No;
    }
}
