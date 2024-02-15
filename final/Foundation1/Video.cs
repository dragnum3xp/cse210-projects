public class Video{

    public string _title;
    public string _author;
    public int _length;

    public List<Comment> _list;

    public void description(){
        
        Console.WriteLine($"{_title} {_author} {_length}\n");

}}
