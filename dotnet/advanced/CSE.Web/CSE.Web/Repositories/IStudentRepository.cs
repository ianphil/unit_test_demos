using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CSE.Web.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace CSE.Web.Repositories
{
    public interface IStudentRepository : IDisposable
    {
        Task<IEnumerable<Student>> GetStudents();
        Task<Student> GetStudentByID(int studentId);
        Task InsertStudent(Student student);
        Task DeleteStudent(int studentID);
        Task UpdateStudent(Student student);
        Task Save();
    }
}
