using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartialView.Models
{
    public class Films
    {
        public Films()
        {
            FilmsDetails film = new FilmsDetails();

            film.Title = "RRR";
            film.Duration = "Two hours";
            film.Description = "Actoion and Drama";
            FilmsDetails = new List<FilmsDetails>();
            FilmsDetails.Add(film);

            film = new FilmsDetails();
            film.Title = "F2";
            film.Duration = "Two and half hours";
            film.Description = "Comedy";
            FilmsDetails.Add(film);

            film = new FilmsDetails();
            film.Title = "Bahubali";
            film.Duration = "Three Hours";
            film.Description = "Social Fantacy";
            FilmsDetails.Add(film);

            film = new FilmsDetails();
            film.Title = "Venom";
            film.Duration = "Two and half hours";
            film.Description = "Thriller";
            FilmsDetails.Add(film);

            film = new FilmsDetails();
            film.Title = "Quite Place";
            film.Duration = "Three Hours";
            film.Description = "Horror";
            FilmsDetails.Add(film);

        }

        public List<FilmsDetails> FilmsDetails { get; set; }
    }
}
