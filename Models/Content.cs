using System.ComponentModel.DataAnnotations;

public class Content
{
    [Required]
    public string Id { get; set; }
    [Required]
    public string Post { get; set; }
    [Required]
    public int LikesCount { get; set; }
    [Required]
    public string OwnerId { get; set; }

    public Content(string post, string ownerId)
    {
        Id = Guid.NewGuid().ToString();
        Post = post;
        LikesCount = 0;
        OwnerId = ownerId;
    }
}