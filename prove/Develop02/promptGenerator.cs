public class PromptGenerator
{
    public List<string> _promptList = new List<string>()
        {
            "How have you seen the Lord's hand in your life today?",
            "Have you done any good deeds today?",
            "What is one thing you can start doing right now to improve yourself?",
            "What challenges did you face today? How did you overcome them?",
            "What is something you are grateful for?",
            "What is something nice someone did for you today?",
            "What is something you are looking forward to?",
            "How was the weather today?",
            "What is something interesting you learned today?",
            "Did you do anything fun today?"
        };
    public string GetPrompt()
    {
        Random rand = new Random();
        int index;

        index = rand.Next(0, _promptList.Count);
        string prompt = _promptList[index];
        return prompt;
    }
}