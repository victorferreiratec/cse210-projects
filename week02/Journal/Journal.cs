using System;
using System.Linq.Expressions;

public class Journal
{    
    public List<Entry> _entries = new List<Entry>();


    // Constructor
    public Journal()
    {
    }
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
        Console.WriteLine("Entry added successfully!\n");
    }
     public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries found in the  journal.");
        }
        else
        {
            foreach (var entry in _entries)
            {
                entry.Display();
            }
        }
    }
    public void SaveToFile()
    {
        Console.Write("Enter a filename to save your journal: ");
        string filename = Console.ReadLine();

        string existingPassword = null;

        // Check if file exists
        if (File.Exists(filename))
        {
            try
            {
                using (StreamReader reader = new StreamReader(filename))
                {
                    string firstLine = reader.ReadLine();
                    if (firstLine.StartsWith("PASSWORD:"))
                    {
                        // Extract the saved passoword
                        existingPassword = firstLine.Substring(9);  
                    }
                }
            }
            catch ( Exception ex)
            {
                Console.WriteLine($"Error reading existing file : {ex.Message}\n");
            }

        }

        
        if (existingPassword == null)
        {
            Console.Write("Set a password to protect this journal: ");
            existingPassword = Console.ReadLine();
        }


        try 
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                writer.WriteLine($"PASSWORD: {existingPassword}");

                foreach (var entry in _entries)
                {
                    writer.WriteLine(entry.MakeEntryText());
                    
                }
            }

            Console.WriteLine("Journal saved successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving journal : {ex.Message}\n");
        } 
    }
    public void LoadFromFile()
    {   
        Console.Write("Enter a filename to load the journal from: ");
        string filename = Console.ReadLine();

        try
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                //Read and verify password
                string firstLine = reader.ReadLine();
                
                string storedPassword = firstLine.Substring(10); // Extract stored password 
                Console.Write("Enter the password: ");
                string enteredPassword = Console.ReadLine();

                // if password is incorrect, communicates to the user and return to menu
                if (enteredPassword != storedPassword)
                {
                    Console.WriteLine("Incorrect password! Access denied.");
                    return;
                }
                // if the password is correct load the file 
                _entries.Clear();

                // Load the rest of the journal entries
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string prompt = line.Substring(26); //Ignore the date and get only the prompt.
                    string answer = reader.ReadLine();
                    _entries.Add(new Entry(prompt, answer));
                    reader.ReadLine(); //Skip the blank line between _enteries.
                }
            }

            Console.WriteLine("Journal loadded successfully!");
        }

        catch (Exception ex)
            {
                Console.WriteLine($"Error loading journal: {ex.Message}\n");
            }
    }
}