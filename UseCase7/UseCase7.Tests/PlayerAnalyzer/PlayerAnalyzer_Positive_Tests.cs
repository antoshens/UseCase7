namespace UseCase7.Tests.PlayerAnalyzer
{
    [Collection("PlayerAnalyzer")]
    public class PlayerAnalyzer_Positive_Tests: IClassFixture<PlayerAnalyzerFixture>, IDisposable
    {
        private readonly PlayerAnalyzerFixture _fixture;

        public PlayerAnalyzer_Positive_Tests(PlayerAnalyzerFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public void Should_Return250_When_SinglePlayerAge25Experience5AndSkillsAll2()
        {
            _fixture.Players.Add(new Player { Age = 25, Experience = 5, Skills = new List<int> { 2, 2, 2 } });

            Assert.Equal(250, _fixture.Analyzer.CalculateScore(_fixture.Players));
        }

        [Fact]
        public void Should_Return67Point5_When_SinglePlayerAge15Experience3AndSkillsAll3()
        {
            _fixture.Players.Add(new Player { Age = 15, Experience = 3, Skills = new List<int> { 3, 3, 3 } });

            Assert.Equal(67.5, _fixture.Analyzer.CalculateScore(_fixture.Players));
        }

        [Fact]
        public void Should_Return2520_When_SinglePlayerAge35Experience15AndSkillsAll4()
        {
            _fixture.Players.Add(new Player { Age = 35, Experience = 15, Skills = new List<int> { 4, 4, 4 } });

            Assert.Equal(2520, _fixture.Analyzer.CalculateScore(_fixture.Players));
        }

        [Fact]
        public void Should_ReturnSumOfScores_When_MultiplePlayers()
        {
            _fixture.Players.AddRange(new List<Player>
            {
                new Player { Age = 25, Experience = 5, Skills = new List<int> { 2, 2, 2 } },
                new Player { Age = 15, Experience = 3, Skills = new List<int> { 3, 3, 3 } },
                new Player { Age = 35, Experience = 15, Skills = new List<int> { 4, 4, 4 } }
            });

            Assert.Equal(2837.5, _fixture.Analyzer.CalculateScore(_fixture.Players));
        }

        public void Dispose()
        {
            _fixture.Dispose();
        }
    }
}
