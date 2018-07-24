using CSE.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSE.Web.Services
{
    public interface IStudentService
    {
        Task<IEnumerable<Student>> GetStudents();
        Task<Student> GetStudentByID(int studentId);
        Task InsertStudent(Student student);
        Task DeleteStudent(int studentID);
        Task UpdateStudent(Student student);
    }
}
