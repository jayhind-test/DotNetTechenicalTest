using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer;

namespace WebApplication
{
    public class FilmController : ControllerBase
    {
        //get all
        [HttpGet]
        [Route("films")]
        public async Task<IActionResult> GetAll()
        {
            FilmService service = new FilmService();

            IEnumerable dtos = await service.GetAllAsync();

            List<FilmResource> films = new List<FilmResource>();
            
            return Ok(films);
        }
        
        //post
        [HttpPost]
        [Route("films")]
        public async Task<IActionResult> Post(FilmTemplate filmTemplate)
        {
            FilmService service = new FilmService();

            Guid filmId = await service.CreateAsync(new CreateFilmDto
            {
                Name = filmTemplate.Name,
                Rating = filmTemplate.Rating,
                Year = filmTemplate.Year
            });
            
            return Ok(filmId);
        }
        
        //delete
        
        //update
    }
}