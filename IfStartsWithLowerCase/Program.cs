//Given a string, write a method that checks if each word in the string starts with lower case and if so, removes this letter from the string.
//Expected input and output
//IfStartsWithLowerCase("Alfa Beta gamma") → "Alfa Beta amma"

global using static System.Console;

WriteLine(IfStartsWithLowerCase("tthis iis ffake ssentence."));
WriteLine(IfStartsWithLowerCase("Praesent vitae convallis purus."));

string IfStartsWithLowerCase(string word)
{
    string[] words = word.Split(' ');

        for (int i=0;i< words.Length;i++)
        {
            if (char.IsLower(words[i][0]))
            {
                words[i] = words[i].Substring(1);
            }
        }
        
    return string.Join(" ", words);
}