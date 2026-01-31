public class Entry
{
    public string _date;
    public string _prompt;
    public string _entry;

    public Entry(string date, string prompt, string entry)
{
    _date = date;
    _prompt = prompt;
    _entry = entry;
}
    
    public void Display()
    {
        Console.WriteLine($"{_date} - {_prompt}");
        Console.WriteLine(_entry);
    }
}