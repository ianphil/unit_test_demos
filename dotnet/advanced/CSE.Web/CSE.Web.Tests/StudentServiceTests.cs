using CSE.Web.Repositories;
using CSE.Web.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace CSE.Web.Tests
{
    [TestClass]
    public class StudentServiceTests
    {
        private IStudentService _contrivedStudentService;
        private IStudentRepository _contrivedStudentRepository;

        private IStudentService _mockStudentService;
        private Mock<IStudentRepository> _mockStudnetRepository;

        [ClassInitialize]
        public void ClassInit(TestContext ts)
        {
            _contrivedStudentRepository = 

            _mockStudnetRepository = new Mock<IStudentRepository>();
            _mockStudentService = new StudentService(_mockStudnetRepository.Object);
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
