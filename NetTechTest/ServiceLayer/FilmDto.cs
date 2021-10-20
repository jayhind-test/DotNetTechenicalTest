using System;

namespace ServiceLayer
{
    public class FilmDto
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
        
        public decimal Rating { get; set; }
        
        public string Year { get; set; }
    }
}