namespace Add.ons.Web.Models;

public class Aplikasi 
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Desc { get; set; }
    public string LinkImage { get; set; }
    public User User { get; set; }
    private int TotalRating { get; set; }

    public Aplikasi(int id, string title, string desc)
    {
        if(id == 0){
            Id = new Random().Next();
        } else {
            Id = id;
        }

        Title = title;
        Desc = desc;
    }

    public void PostBy(User user){
        User = user;
    }
}