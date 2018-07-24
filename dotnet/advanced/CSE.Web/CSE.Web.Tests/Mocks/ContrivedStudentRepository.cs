using CSE.Web.Models;
using CSE.Web.Repositories;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

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
            return new Task(() => 
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
            return new Task<Student>(() => 
            {
                return _students.Find(x => x.StudentId == studentId);
            });
        }

        public Task<IEnumerable<Student>> GetStudents()
        {
            return new Task<IEnumerable<Student>>(() =>
            {
                return _students;
            });
        }

        public Task InsertStudent(Student student)
        {
            return new Task(() =>
            {
                _students.Add(student);
            });
        }

        public Task Save()
        {
            return new Task(() => { });
        }

        public Task UpdateStudent(Student student)
        {
            return new Task(() => 
            {
                DeleteStudent(student.StudentId);
                InsertStudent(student);
            });
        }
    }
}
