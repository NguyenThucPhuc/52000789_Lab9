using StudentServiceLib;

namespace TestProject1
{
    [TestClass]
    public class testStudent
    {
        [TestMethod]
        public void addFirstStudent_Should_Success()
        {
            StudentService service = new StudentService();

            Student s = new Student() { Id = 1, Name = "Phuc", Age = 20, Score = 8 };

            bool status = service.addStudent(s);
            int length = service.size();
            Assert.IsTrue(status);
            Assert.AreEqual(1, length);

        }
        [TestMethod]
        public void addADuplicatStudentId_ShouldReturn_False()
        {
            StudentService service = new StudentService();

            Student s1 = new Student() { Id = 1, Name = "Phuc", Age = 20, Score = 8 };
            Student s2 = new Student() { Id = 1, Name = "Phuc", Age = 20, Score = 8 };

            service.addStudent(s1);
            bool status = service.addStudent(s2);
            Assert.IsFalse(status);

        }
        [TestMethod]
        public void passingNullParemeter_ShouldThrow_NullRefException()
        {
            StudentService sv = new StudentService();

            bool exceptionThrown = false;
            try
            {
                sv.addStudent(null);
            }catch (NullReferenceException e)
            {
                exceptionThrown = true;
            }
            Assert.IsTrue(exceptionThrown);
        }
        [TestMethod]
        public void findStudent_byAge_Should_Success()
        {
            StudentService service = new StudentService();
            Student s1 = new Student() { Id = 1, Name = "Phuc", Age = 19, Score = 8 };
            Student s2 = new Student() { Id = 2, Name = "Phuc1", Age = 20, Score = 8 };
            Student s3 = new Student() { Id = 3, Name = "Phuc2", Age = 21, Score = 8 };
            Student s4 = new Student() { Id = 4, Name = "Phuc3", Age = 22, Score = 8 };
            Student s5 = new Student() { Id = 5, Name = "Phuc4", Age = 20, Score = 8 };
            Student s6 = new Student() { Id = 6, Name = "Phuc5", Age = 23, Score = 8 };
            service.addStudent(s1);
            service.addStudent(s2);
            service.addStudent(s3);
            service.addStudent(s4);
            service.addStudent(s5);
            service.addStudent(s6);

            service.findStudentByAge(21);
            Assert.AreEqual(s3, service.findStudentByAge(21));

        }
    }
}