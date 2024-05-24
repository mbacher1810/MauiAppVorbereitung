using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppVorbereitung.Models;

public class Film
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public int Duration { get; set; }

    public Film(int id, string title, string description, 
        int duration)
    {
        Id = id;
        Title = title;
        Description = description;  
        Duration = duration;
    }

}
