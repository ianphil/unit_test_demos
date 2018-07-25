using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSE.Web.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace CSE.Web.Repositories
{
    public class StudentRepository : IStudentRepository, IDisposable
    {
        private SchoolContext _context;

        public StudentRepository(SchoolContext context)
        {
            _context = context;
        }

        public StudentRepository()
        {
            DbContextOptionsBuilder<SchoolContext> optionsBuilder = new DbContextOptionsBuilder<SchoolContext>().UseSqlServer(Startup.connection);
            _context = new SchoolContext(optionsBuilder.Options);
        }

        public async Task<List<Student>> GetStudents()
        {
            return await _context.Students.ToListAsync();
        }

        public async Task<Student> GetStudentByID(int id)
        {
            return await _context.Students.FindAsync(id);
        }

        public async Task InsertStudent(Student student)
        {
            await _context.Students.AddAsync(student);
        }

        public Task DeleteStudent(int studentID)
        {
            return new Task(() =>
            {
                Student student = _context.Students.Find(studentID);
                _context.Students.Remove(student);
            });
        }

        public Task UpdateStudent(Student student)
        {
            return new Task(() =>
            {
                _context.Entry(student).State = EntityState.Modified;
            });
        }

        public Task Save()
        {
            return new Task(() =>
            {
                _context.SaveChangesAsync();
            });
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
