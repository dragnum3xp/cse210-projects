using System.Collections.Generic;
using System.Text;



public class Comment
{
    public string _comment;
    public string _authComment;

    public string commentDescription(List<Comment> comments)
    {
        StringBuilder stringBuilder = new StringBuilder();

        foreach (Comment comment in comments)
        {
            stringBuilder.AppendLine($"Author: {comment._authComment}.\n{comment._comment}");
        }

        return stringBuilder.ToString();
    }
}