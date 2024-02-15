using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Video v1 = new Video();
        v1._author = "cameo";
        v1._title = "How to code in C#";
        v1._length = 1250;
        v1._list = new List<Comment>();
        
        Comment auth1 = new Comment();
        auth1._authComment = "mark";
        auth1._comment = "Very good!";
        v1._list.Add(auth1);

        Comment auth2 = new Comment();
        auth2._authComment = "cameo";
        auth2._comment = "Nice tutorial!";
        v1._list.Add(auth2);

        Video v2 = new Video();
        v2._author = "august";
        v2._title = "How to code in java";
        v2._length = 1370;
        v2._list = new List<Comment>();

        Comment auth3 = new Comment();
        auth3._authComment = "marcos";
        auth3._comment = "You teach well!";
        v2._list.Add(auth3);

        Comment auth4 = new Comment();
        auth4._authComment = "Manike";
        auth4._comment = "Nice tutorial!";
        v2._list.Add(auth4);
        

        Comment comment = new Comment(); 
        


        Comment comment2 = new Comment(); 
        

        List<Video> vilist = new List<Video>();

        vilist.Add(v1);
        vilist.Add(v2);

        foreach (Video v in vilist)
        {
            Console.WriteLine($"Title: {v._title}");
            Console.WriteLine($"Author: {v._author}");
            Console.WriteLine($"Length: {v._length}");

            Console.WriteLine("Comments:");
            Console.WriteLine(comment.commentDescription(v._list));
            Console.WriteLine();
        }
}}