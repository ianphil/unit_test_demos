using CSE.Web.Models;
using CSE.Web.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSE.Web.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public StudentService()
        {
            _studentRepository = new StudentRepository();
        }

        public async Task<IEnumerable<Student>> GetStudents()
        {
            return await _studentRepository.GetStudents();
        }

        public async Task<Student> GetStudentByID(int id)
        {
            return await _studentRepository.GetStudentByID(id);
        }

        public async Task InsertStudent(Student student)
        {
            await _studentRepository.InsertStudent(student);
            await _studentRepository.Save();
        }

        public async Task DeleteStudent(int studentID)
        {
            await _studentRepository.DeleteStudent(studentID);
            await _studentRepository.Save();
        }

        public async Task UpdateStudent(Student student)
        {
            await _studentRepository.UpdateStudent(student);
            await _studentRepository.Save();
        }
    }
}
