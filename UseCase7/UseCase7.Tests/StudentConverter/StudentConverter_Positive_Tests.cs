namespace UseCase7.Tests.StudentConverter
{
    public class StudentConverter_Positive_Tests
    {
        private readonly UseCase7.StudentConverter _studentConverter;

        public StudentConverter_Positive_Tests()
        {
            _studentConverter = new UseCase7.StudentConverter();
        }

        [Fact]
        public void Should_SetHonorRollTrue_When_AgeAbove21AndGradeAbove90()
        {
            var students = new List<Student> { new Student { Age = 22, Grade = 91 } };
            var result = _studentConverter.ConvertStudents(students);

            Assert.Single(result);
            Assert.True(result[0].HonorRoll);
        }

        [Fact]
        public void Should_SetExceptionalTrue_When_AgeBelow21AndGradeAbove90()
        {
            var students = new List<Student> { new Student { Age = 20, Grade = 91 } };
            var result = _studentConverter.ConvertStudents(students);

            Assert.Single(result);
            Assert.True(result[0].Exceptional);
        }

        [Fact]
        public void Should_SetPassedTrue_When_GradeBetween71And90()
        {
            var students = new List<Student> { new Student { Age = 20, Grade = 80 } };
            var result = _studentConverter.ConvertStudents(students);

            Assert.Single(result);
            Assert.True(result[0].Passed);
        }

        [Fact]
        public void Should_SetPassedFalse_When_Grade70OrBelow()
        {
            var students = new List<Student> { new Student { Age = 20, Grade = 70 } };
            var result = _studentConverter.ConvertStudents(students);

            Assert.Single(result);
            Assert.False(result[0].Passed);
        }
    }
}
