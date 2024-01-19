using System;
using System.IO;
using System.Collections.Generic;

class Journal
{
    public List<Entry> _entries;

    
    public void AddEntry(Entry newEntry)
    {   
        if (_entries == null)
        {
            _entries = new List<Entry>();
        }
        _entries.Add(newEntry);

    }

    public void DisplayEntries()
    {
        foreach (Entry e in _entries)
        {
            e.Display();
        };
    }

    public void SaveFile(string file){
        
        using (StreamWriter text = new StreamWriter(file))
        {
            
            foreach (Entry e in _entries)
            {
                text.WriteLine($"{e._prompt}~~{e._answer}~~{e._date}");
            }
        }
    }

    public void LoadFile(string file){
        
        string filename = file;

        if (_entries == null)
        {
            _entries = new List<Entry>();
        }
        _entries.Clear();

        string[] lines =System.IO.File.ReadAllLines(filename);
        
        foreach (string line in lines)
        {
            string[] parts = line.Split("~~");
            Entry loadedEntry = new Entry
            {
                _prompt = parts[0],
                _answer = parts[1],
                _date = parts[2]
            };
             _entries.Add(loadedEntry);
        }
    }
}