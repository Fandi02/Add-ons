using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Add.ons.Web.Models;

public class AplikasiViewModel
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Desc { get; set; }
    public int TotalLike { get; set; }


    public AplikasiViewModel(int id, string title, string desc, int totalLike)
    {
        Id = id;
        Title = title;
        Desc = desc;
        TotalLike = totalLike;
    }
}
