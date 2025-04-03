using System.Text;

namespace ExercicioResolvido02.Entities;

public class Post
{
    public DateTime Moment { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public int Likes { get; set; }
    public List<Comment> Comments { get; set; } = new List<Comment>();

    public Post()
    {
    }
    public Post(DateTime Moment, string Title, string Content, int Likes)
    {
        this.Moment = Moment;
        this.Title = Title;
        this.Content = Content;
        this.Likes = Likes;
    }

    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }

    public void RemoveComment(Comment comment)
    {
        Comments.Remove(comment);
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(Title);
        sb.Append(Likes);
        sb.Append(" Likes - ");
        sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
        sb.AppendLine(Content);
        sb.AppendLine("Comments: ");
        foreach (Comment c in Comments)
        {
            sb.AppendLine(c.Text);
        }
        return sb.ToString();
    }

}