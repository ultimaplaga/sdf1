using System.Collections.Generic;

namespace sdf1
{
    public class Student
    {
        public string Code { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public List<Grade> Grades { get; set; }
            = new List<Grade>();
    }
}