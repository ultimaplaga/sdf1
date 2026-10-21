using System;
using System.Collections.Generic;

namespace sdf1
{
    public class StudentService : IStudentService
    {
        public static List<Student> Students = new List<Student>();

        public bool AddStudent(Student student)
        {
            if (student == null || string.IsNullOrWhiteSpace(student.Code))
                return false;

            student.Code = student.Code.Trim();

            if (FindStudent(student.Code) != null)
                return false;

            Students.Add(student);
            return true;
        }

        public Student FindStudent(string code)
        {
            if (string.IsNullOrWhiteSpace(code))
                return null;

            foreach (Student student in Students)
            {
                if (string.Equals(student.Code, code.Trim(),
                    StringComparison.OrdinalIgnoreCase))
                {
                    return student;
                }
            }

            return null;
        }

        public bool AddGrade(string studentCode, string subject, int score)
        {
            Student student = FindStudent(studentCode);

            if (student == null || score < 0 || score > 100 ||
                string.IsNullOrWhiteSpace(subject))
            {
                return false;
            }

            Grade grade = new Grade
            {
                Subject = subject.Trim(),
                Score = score
            };

            student.Grades.Add(grade);
            return true;
        }

        public List<Grade> GetStudentGrades(string studentCode)
        {
            Student student = FindStudent(studentCode);

            if (student == null)
                return null;

            return student.Grades;
        }

        public List<Student> GetAllStudents()
        {
            return Students;
        }
    }
}