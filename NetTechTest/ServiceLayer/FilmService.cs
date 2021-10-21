using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public class FilmService
    {
        public FilmService()
        {
        }

        public async Task<IEnumerable<FilmDto>> GetAllAsync()
        {
            return new List<FilmDto>();
        }

        public async Task<Guid> CreateAsync(CreateFilmDto createFilmDto)
        {
            return Guid.Empty;
        }
    }
}