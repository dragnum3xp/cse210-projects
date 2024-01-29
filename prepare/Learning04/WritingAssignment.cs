public class WritingAssignment : Assignment
{
    protected string _title;
    public WritingAssignment(string student, string topic, string title) : base(student, topic){

        _title = title;
    }

    public string GetWritingInformation()
    {
        return $"{_studentName} - {_topic}\n{_title}";

    }
}