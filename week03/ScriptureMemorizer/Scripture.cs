using System.Collections.Generic;

public class Scripture
{
    // Attributes
    private Reference _reference;
    private List<Word> _words;

    // Constructor
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        // Logic to split text into words will be added later
    }

    // Behaviors
    public void HideRandomWords(int numberToHide)
    {
        // Implementation will be added later
    }

    public string GetDisplayText()
    {
        return "";
    }

    public bool IsCompletelyHidden()
    {
        return false;
    }
}
