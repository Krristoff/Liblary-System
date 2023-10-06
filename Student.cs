using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteka
{
    class Student : User
    {

        public Student(string name) : base(name)
        {
            BorrowLimit = 5;
            BorrowDuration = 14;
        }

        public override string ToString()
        {
            return $"student: {base.ToString()}";
        }
    }
}
