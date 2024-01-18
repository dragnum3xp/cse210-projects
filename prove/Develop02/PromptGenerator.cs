//holds the list of possible prompts
//has a function to select a random promt out of the list



using System.Diagnostics.CodeAnalysis;

public class PromptGenerator
{
    public List<string> _promptsList;


    public string ChooseRandom(string file)
    {
        string line;

        StreamReader sr = new StreamReader(file);
        line = sr.ReadLine();
        while (line != null)
        {
            
            if (_promptsList == null)
            {
                _promptsList = new List<string>();
            } else {
                _promptsList.Add(line);
            line = sr.ReadLine();
            }
                
        }
        sr.Close();
        var random = new Random();
        int index = random.Next(_promptsList.Count);
        
        return _promptsList[index];
    }
}