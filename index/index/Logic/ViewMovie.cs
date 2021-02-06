using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace index
{
    public class ViewMovie
    {
        public int Index { get; set; }
        public long Budget { get; set; }
        public string Genres { get; set; }
        public int Id { get; set; }
        public string Keywords { get; set; }
        public string Original_language { get; set; }
        public string Original_title { get; set; }
        public string Overview { get; set; }
        public double Popularity { get; set; }
        public DateTime Release_date { get; set; }
        public int Runtime { get; set; }
        public string Status { get; set; }
        public string Tagline { get; set; }
        public string Title { get; set; }
        public double Vote_average { get; set; }
        public int Vote_count { get; set; }
        public string Cast { get; set; }
        public string Director { get; set; }
        


        public ViewMovie(movie_dataset_fixed movie)
        {
            this.Index = movie.index;
            this.Budget = movie.budget;
            this.Genres = movie.genres;
            this.Id = movie.id;
            this.Keywords = movie.keywords;
            this.Original_language = movie.original_language;
            this.Original_title = movie.original_title;
            this.Overview = movie.overview;
            this.Popularity = movie.popularity;
            this.Release_date = movie.release_date;
            this.Runtime = movie.runtime;
            this.Status = movie.status;
            this.Tagline = movie.tagline;
            this.Title = movie.title;
            this.Vote_average = movie.vote_average;
            this.Vote_count = movie.vote_count;
            this.Cast = movie.cast;
            this.Director = movie.director;

        }
    }
}
