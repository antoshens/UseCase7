namespace UseCase7.Tests.PlayerAnalyzer
{
    public class PlayerAnalyzerFixture : IDisposable
    {
        public UseCase7.PlayerAnalyzer Analyzer { get; } = new UseCase7.PlayerAnalyzer();
        public List<Player> Players { get; set; } = new List<Player>();

        public void Dispose()
        {
            Players.Clear();
        }
    }
}
