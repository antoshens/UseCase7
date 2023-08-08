namespace UseCase7.Tests.StudentConverter
{
    public class StudentConverter_Negative_Tests
    {
        private readonly UseCase7.StudentConverter _studentConverter;

        public StudentConverter_Negative_Tests()
        {
            _studentConverter = new UseCase7.StudentConverter();
        }

        [Fact]
        public void Should_ReturnEmptyList_When_InputListIsEmpty()
        {
            var students = new List<Student>();
            var result = _studentConverter.ConvertStudents(students);

            Assert.Empty(result);
        }

        [Fact]
        public void Should_ThrowException_When_InputIsNull()
        {
            Assert.Throws<ArgumentNullException>(() => _studentConverter.ConvertStudents(null));
        }
    }
}
