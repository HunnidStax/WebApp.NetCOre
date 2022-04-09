﻿using System.Text;

public class Post
{
    public int UserId { get; set; }
    public int Id { get; set; }
    public string Title { get; set; }
    public string Body { get; set; }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(UserId.ToString());
        sb.AppendLine(Id.ToString());
        sb.AppendLine(Title);
        sb.AppendLine(Body);
        return sb.ToString();
    }
}