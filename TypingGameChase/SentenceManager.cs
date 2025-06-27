namespace TypingGameChase
{
    internal class SentenceManager
    {
        private List<string> sentences = new List<string>
        {
            "In the dynamic landscape of technology, continuous learning and disciplined practice remain the cornerstone of achieving excellence and maintaining a competitive edge in any industry",
            "Efficiency and precision are paramount in the development lifecycle, where meticulous attention to detail transforms innovative concepts into robust, scalable software solutions",
            "As we integrate artificial intelligence and automation into everyday workflows, adaptability and strategic foresight become essential skills for future-ready professionals",
            "Consistent practice, coupled with analytical thinking and problem-solving capabilities, propels individuals from mere competence to mastery in their chosen fields",
            "Navigating the complexities of modern software engineering demands not only technical prowess but also strong communication skills and a collaborative mindset"
        };

        private Random random = new Random();

        public string GetRandomSentence()
        {
            int index = random.Next(sentences.Count);
            return sentences[index];
        }
    }
}
