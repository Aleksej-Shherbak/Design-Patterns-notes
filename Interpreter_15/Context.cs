namespace Interpreter_15
{
    public class Context
    {
        // Контекст распознающей граматики яыка:
        // V = {a}; L = V* (бесконечное множество);
        // Правильные цепочки: a, aa, aaa, ...
        // Неправильные цепочки: b, ab, aba, ...

        /// <summary>
        /// Исходное слово
        /// </summary>
        public string Source { get; set; }
        
        /// <summary>
        /// Словарь (да, такой примитивный, из одной буквы)
        /// </summary>
        public char Vocabulary { get; set; }
        public bool Result { get; set; }
        public int Position { get; set; }
    }
}