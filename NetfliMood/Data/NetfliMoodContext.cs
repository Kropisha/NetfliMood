using Microsoft.EntityFrameworkCore;
using NetfliMood.Models;

namespace NetfliMood.Data
{
    public class NetfliMoodContext:DbContext
    {
        public NetfliMoodContext(DbContextOptions<NetfliMoodContext> options)
            :base(options)
        {
            //Database.EnsureCreated();
        }

        public DbSet<Movie> Movies { get; set; }

        public DbSet<Actor> Actors { get; set; }

        public DbSet<Director> Directors { get; set; }

        public DbSet<Genre> Genres { get; set; }

        public DbSet<ActorMovieRelation> ActorMovieRelations { get; set; }

        public DbSet<MovieGenreRelation> MovieGenreRelations { get; set; }
    }
}
