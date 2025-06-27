using System.Diagnostics;

namespace TypingGameChase
{
    internal class GameEngine
    {
        public Player Player { get; set; }
        public Fish Fish { get; set; }
        public Shark Shark { get; set; }
        public SentenceManager SentenceManager { get; set; } = new SentenceManager();
        public Stopwatch TypingStopwatch { get; set; } = new Stopwatch();
        public int MistakeCount { get; set; }
    }
}
