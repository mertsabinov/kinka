using System.ComponentModel.DataAnnotations;

public class Content
{
    [Required]
    public string Id { get; set; }
    [Required]
    public string PostTitle { get; set; }
    [Required]
    public string Post { get; set; }
    [Required]
    public List<string> UsersWhoLike { get; set; }
    [Required]
    public string OwnerUserName { get; set; }
    public Content() {}
    public Content(string postTitle, string post, string ownerId)
    {
        Id = Guid.NewGuid().ToString();
        PostTitle = postTitle;
        Post = post;
        UsersWhoLike = new List<string>();
        OwnerUserName = ownerId;
    }

}