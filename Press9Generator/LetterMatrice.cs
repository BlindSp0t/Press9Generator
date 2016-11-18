namespace Press9Generator
{
    /// <summary>
    /// Each letters is rendered on 5 lines
    /// so this cuts down a letter line by line
    /// for easier message translation
    /// There's an identifying char to compare
    /// with the user's input
    /// </summary>
    public class LetterMatrice
    {
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Line3 { get; set; }
        public string Line4 { get; set; }
        public string Line5 { get; set; }
        public char Char { get; set; }
    }
    
}
