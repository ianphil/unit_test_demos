using CSE.Web.Models;
using CSE.Web.Repositories;
using CSE.Web.Services;
using CSE.Web.Tests.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSE.Web.Tests
{
    [TestClass]
    public class StudentServiceTests
    {
        private static IStudentService _contrivedStudentService;
        private static IStudentRepository _contrivedStudentRepository;

        private static IStudentService _mockStudentService;
        private static Mock<IStudentRepository> _mockStudnetRepository;

        [ClassInitialize]
        public static void ClassInit(TestContext ts)
        {
            _contrivedStudentRepository = new ContrivedStudentRepository();
            _contrivedStudentService = new StudentService(_contrivedStudentRepository);

            SetupMoq();
        }

        [TestMethod]
        public async Task ContrivedGetStudents()
        {
            var expected = 2;
            var actual = await _contrivedStudentService.GetStudents();

            Assert.AreEqual(expected, actual.Count());
        }

        [TestMethod]
        public async Task ContrivedInsertStudent()
        {
            var expected = 3;
            var newStudent = new Student { StudentId = 3, FirstName = "Bree", LastName = "Philpot" };
            await _contrivedStudentService.InsertStudent(newStudent);

            var actual = await _contrivedStudentService.GetStudents();

            Assert.AreEqual(expected, actual.Count());
        }

        [TestMethod]
        public async Task MockGetStudents()
        {
            var expected = 1;
            var actual = await _mockStudentService.GetStudents();

            Assert.AreEqual(expected, actual.Count());
        }

        private static void SetupMoq()
        {
            _mockStudnetRepository = new Mock<IStudentRepository>();
            var expectedResult = Task.Run(() => new List<Student> { new Student { StudentId = 0 } });
            _mockStudnetRepository.Setup(x => x.GetStudents()).Returns(expectedResult);
            _mockStudentService = new StudentService(_mockStudnetRepository.Object);
        }
    }
}
