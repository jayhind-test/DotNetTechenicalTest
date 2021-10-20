using System;

namespace ServiceLayer
{
    public class Film
    {
        public Guid Id { get; set; }
        
        public string Name { get; set; }
        
        public string Year { get; set; }
        
        public decimal Rating { get; set; }
    }
}