using System;
using System.Collections;
using System.Collections.Generic;
using ServiceLayer;

namespace PersistenceLayer
{
    public class FilmRepository
    {
        private List<Film> _films;

        private const string _connectionString =
            "Server=tcp:technicaltestserver.database.windows.net,1433;Initial Catalog=TechnicalTest;Persist Security Info=False;User ID=techtestadmin;Password=P4ssw0rd;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        public FilmRepository()
        {
            _films = new List<Film>
            {
                new Film {Id = Guid.NewGuid(), Name = "Venom", Rating = 6.7m, Year = "2018"},
                new Film {Id = Guid.NewGuid(), Name = "Venom : Let there be Carnage", Rating = 6.4m, Year = "2021"},
                new Film {Id = Guid.NewGuid(), Name = "The Hunt for Red October", Rating = 7.6m, Year = "1990"},
                new Film {Id = Guid.NewGuid(), Name = "The Italian Job", Rating = 7.3m, Year = "1969"},
                new Film {Id = Guid.NewGuid(), Name = "The Dark Knight", Rating = 9.0m, Year = "2008"},
                new Film {Id = Guid.NewGuid(), Name = "Sin City", Rating = 8.0m, Year = "2005"},
                new Film {Id = Guid.NewGuid(), Name = "The Rock", Rating = 7.4m, Year = "1996"},
                new Film {Id = Guid.NewGuid(), Name = "Rush", Rating = 8.1m, Year = "2013"},
                new Film {Id = Guid.NewGuid(), Name = "Saw", Rating = 7.6m, Year = "2004"},
                new Film {Id = Guid.NewGuid(), Name = "The Shining", Rating = 8.4m, Year = "1980"},
            };
        }
        
        public IEnumerable<Film> GetAll()
        {
            return _films;
        }

        public void Add(Film film)
        {
            _films.Add(film);
        }
    }
}