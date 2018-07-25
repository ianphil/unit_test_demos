using CSE.Web.Models;
using CSE.Web.Repositories;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace CSE.Web.Tests.Mocks
{
    public class ContrivedStudentRepository : IStudentRepository
    {
        private List<Student> _students;

        public ContrivedStudentRepository()
        {
            _students = new List<Student>()
            {
                new Student { StudentId = 0, FirstName = "Ian", LastName = "Philpot" },
                new Student { StudentId = 1, FirstName = "Josh", LastName = "Lane" }
            };
        }

        public ContrivedStudentRepository(List<Student> students)
        {
            _students = students;
        }

        public Task DeleteStudent(int studentID)
        {
            return Task.Run(() => 
            {
                _students.RemoveAll(x => x.StudentId == studentID);
            });
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task<Student> GetStudentByID(int studentId)
        {
            return Task.Run(() => 
            {
                return _students.Find(x => x.StudentId == studentId);
            });
        }

        public Task<List<Student>> GetStudents()
        {
            return Task.Run(() =>
            {
                return _students;
            });
        }

        public Task InsertStudent(Student student)
        {
            return Task.Run(() =>
            {
                _students.Add(student);
            });
        }

        public Task Save()
        {
            return Task.CompletedTask;
        }

        public Task UpdateStudent(Student student)
        {
            return Task.Run(() => 
            {
                DeleteStudent(student.StudentId);
                InsertStudent(student);
            });
        }
    }
}
