namespace kinka.Data;

public static class ContentDbManager
{
    private static List<Content> _db = new List<Content>();

    public static List<Content> ContentGetAll()
    {
        return _db;
    }

    public static void ContentSave(Content content)
    {
        content.Id = Guid.NewGuid().ToString();
        content.UsersWhoLike = new List<string>();
        _db.Add(content);
    }
}