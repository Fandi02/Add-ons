using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Add.ons.Web.Models;

public class AplikasiViewModel
{
    [DisplayName("Nomor ")]
    [Required]
    public int Id { get; set; }
    [MaxLength(5)]
    public string Title { get; set; }
    public string Desc { get; set; }
    public int TotalRating { get; set; }
    public string LinkImage { get; set; }
    public User User { get; set; }
    public AplikasiViewModel()
    {

    }
    public AplikasiViewModel(int id, string title, string desc)
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
