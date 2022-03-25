namespace Add.ons.Web.Models;

public class Aplikasi
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Desc { get; set; }
    public int TotalLike { get; set; }
    public string LinkImage { get; set; }

    public Aplikasi(int id, string title, string desc, int totalLike, string linkImage)
    {
        Id = id;
        Title = title;
        Desc = desc;
        TotalLike = totalLike;
        LinkImage = linkImage;
    }
}
