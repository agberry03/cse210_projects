public class PromptGenerator
{
    public List<string> _promptList = new List<string>()
        {
            "How have you seen the Lord's hand in your life today?",
            "What have you done to bring joy to others?",
            "What is one thing you can start doing right now to improve yourself?",
            "What challenges did you face today? How did you overcome them?",
            "What is something you are grateful for?"
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