// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
// Savanna Dickie
// 11/16/2024
// Lab 10: Madlibs #2

using System.Security.Cryptography.X509Certificates;

class Program 
{
    
    
        static void Main(string[] filenames)
        {
            Dictionary<string, List<string>> WordClasses = new Dictionary<string, List<string>>();
            CategoryClasses(WordClasses);
        foreach (string filename in filenames)
        {
            string story = File.ReadAllText(filename);
            //Console.WriteLine(filename);
            if(!File.Exists(filename))
            {
                Console.WriteLine($"does not exist");
            }
            Console.WriteLine(story);

            string finishedStory = WordClassesReplace(story, WordClasses);
            
        }
        }


static void CategoryClasses(Dictionary<string, List<string>> WordClasses)
{
    WordClasses["past-tense-verb"] = new List<string> { "ran", "flew",  "jumped","swam"};
    WordClasses["verb"] = new List<string> { "run", "fly", "jump", "swim"};
    WordClasses["plural-noun"] = new List<string> { "dogs", "cats", "sheep", "birds"};
    WordClasses["noun"] = new List<string> {"dog","cat", "sheep","bird"};
    WordClasses["adjective"] = new List<string> {"colorful","sleepy","energetic", "happy","sad"};

}

static string WordClassesReplace(string story, Dictionary<string, List<string>> WordClasses)
{
    Random rand = new Random();
    string result = story;

    foreach(var category in WordClasses)
    {
        string needsReplacement = "::" + WordClasses.Keys;
        while (result.Contains(needsReplacement))
        {
            string randomWord = category.Value[rand.Next(category.Value.Count)];
            result = result.Replace(needsReplacement, randomWord);
        }
    }
    return result;
}
}





// not sure if this is the issue or the main
/*
static string WordClassesReplace(string story, Dictionary<string, List<string>> WordClasses)
{
    string results = "";
    string[] words = story.Split(' ');
    Random rand = new Random();
    foreach (string word in words)
    {
        if(word.Contains("::"))
        {
        string replace = word.Substring(2);
        
        if(WordClasses.ContainsKey(replace))
        {
            string randomWorld = WordClasses[replace][rand.Next(WordClasses[replace].Count)];
            results += randomWorld + " ";
        }
        }
        //return results;
    }
    return results;
}
}
*/
