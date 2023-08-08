namespace UseCase7.Tests.PlayerAnalyzer
{
    public class PlayerAnalyzer_Negative_Tests : IClassFixture<PlayerAnalyzerFixture>, IDisposable
    {
        private readonly PlayerAnalyzerFixture _fixture;

        public PlayerAnalyzer_Negative_Tests(PlayerAnalyzerFixture fixture)
        {
            _fixture = fixture;
        }

        public void Dispose()
        {
            _fixture.Dispose();
        }

        [Fact]
        public void Should_ThrowError_When_PlayerSkillsAreNull()
        {
            _fixture.Players.Add(new Player { Age = 25, Experience = 5, Skills = null });

            Assert.Throws<ArgumentNullException>(() => _fixture.Analyzer.CalculateScore(_fixture.Players));
        }

        [Fact]
        public void Should_Return0_When_PlayerArrayIsEmpty()
        {
            double score = _fixture.Analyzer.CalculateScore(_fixture.Players);
            Assert.Equal(0, score);
        }
    }
}
