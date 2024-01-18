using System;
using System.IO;

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
        
    }

    public void SaveFile(string file){
        
    }

    public void LoadFile(string file){
        

    }
}