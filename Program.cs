// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
// Savanna Dickie
// 11/16/2024
// Lab 10: Madlibs #2

//class Program 
{
    Dictionary<string, List<string>> WordClasses = new Dictionary<string, List<string>>();
    
        static void Main(string[] filenames)
        {
        foreach (string filename in filenames)
        {
            string story = File.ReadAllText(filename);
            Console.WriteLine(filename);
        }
        }
}

static void CategoryClasses(string story, Dictionary<string, List<string>> WordClasses)
{
    WordClasses["past-tense-verb"] = new List<string> { "ran", "flew",  "jumped","swam"};
    WordClasses["verb"] = new List<string> { "run", "fly", "jump", "swim"};
    WordClasses["plural-noun"] = new List<string> { "dogs", "cats", "sheep", "birds"};
    WordClasses["noun"] = new List<string> {"dog","cat", "sheep","bird"};
    WordClasses["adjective"] = new List<string> {"colorful","sleepy","energetic", "happy","sad"};

}