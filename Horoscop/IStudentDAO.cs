using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horoscop
{
    public interface IStudentDAO
    {
        List<Student> GetStudents();
        Student GetStudentByNumarMatricol(string numarMatricol);
        void AddStudent(Student student);
        bool UpdateStudent(string numarMatricol, Student updatedStudent);
        bool DeleteStudent(string numarMatricol);
    }
}
