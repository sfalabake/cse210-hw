using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> _prompts = new List<string>()
    {
        "What is your favorite hobby?",
        "Describe a memorable vacation you had.",
        "What are three things you are grateful for today?",
        "Write about a challenge you overcame recently.",
        "What is a goal you have for the next month?"
    };

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }
}
