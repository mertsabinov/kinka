public class Content
{
    public string Id { get; set; }
    public string Post { get; set; }
    public int LikesCount { get; set; }
    public string OwnerId { get; set; }

    public Content(string post, string ownerId)
    {
        Id = Guid.NewGuid().ToString();
        Post = post;
        LikesCount = 0;
        OwnerId = ownerId;
    }
}