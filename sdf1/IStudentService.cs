using System.Collections.Generic;

namespace sdf1
{
    public interface IStudentService
    {
        bool AddStudent(Student student);

        Student FindStudent(string code);

        bool AddGrade(string studentCode, string subject, int score);

        List<Grade> GetStudentGrades(string studentCode);

        List<Student> GetAllStudents();
    }
}