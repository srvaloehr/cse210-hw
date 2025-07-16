public class PromptGenerator
{
    public List<string> _prompts = new List<string>
    {
        "How was your day?",
        "What are you grateful for?",
        "What did I feel today?",
        "If I had one thing I could do over today, what would it be?",
        "How can I be 1% better tomorrow?"

    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}