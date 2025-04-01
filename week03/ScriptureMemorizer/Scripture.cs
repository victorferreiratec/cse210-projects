using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        List<string> wordsList = new List<string>(text.Split(' '));

        foreach (string word in wordsList)
        {
            Word newWord = new Word(word);

            _words.Add(newWord);
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random rand = new Random();
        List<Word> availableWords = new List<Word>();
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                availableWords.Add(word);
            }
        }

        for (int i = 0; i < numberToHide && availableWords.Count > 0; i++)
        {
            int index = rand.Next(availableWords.Count);
            availableWords[index].Hide();
            availableWords.RemoveAt(index);
        }
    }

    // As a stretch add this functionality for the user to 
    public void ShowRandomWords(int numberToShow)
    {
        // Check if there are any hidden words
        List<Word> hiddenWords = new List<Word>();
        foreach (Word word in _words)
        {
            if (word.IsHidden()) // Only add hidden words
            {
                hiddenWords.Add(word);
            }
        }

        // If there are no hidden words, inform the user and return early
        if (hiddenWords.Count == 0)
        {
            Console.WriteLine("There are no hidden words to reveal. Press any key to continue...");
            Console.ReadKey();  // Wait for the user to press a key before continuing
            return;
        }

        Random rand = new Random();
        for (int i = 0; i < numberToShow && hiddenWords.Count > 0; i++)
        {
            int index = rand.Next(hiddenWords.Count); // Randomly pick a hidden word
            hiddenWords[index].Show(); // Reveal it
            hiddenWords.RemoveAt(index); // Remove it from the list of hidden words
        }
    }

    public string GetDisplayText()
    {
        string result = _reference.GetDisplayText() + " ";
        foreach (Word word in _words)
        {
            result += word.GetDisplayText() + " ";
        }
        return result.Trim();
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}