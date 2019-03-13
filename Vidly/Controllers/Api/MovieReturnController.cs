using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoMapper;
using Vidly.Dtos;
using Vidly.Models;
using static System.String;

namespace Vidly.Controllers.Api
{
    public class MovieReturnController : ApiController
    {
        private ApplicationDbContext _context;

        public MovieReturnController()
        {
            _context = new ApplicationDbContext();
        }
        //GET /api/MovieReturn
        public IHttpActionResult GetMovies(string query = null)
        {
            var moviesQuery = _context.Movies
                .Include(c => c.Genre);

            if (!IsNullOrWhiteSpace(query))
                moviesQuery = moviesQuery.Where(c => c.Name.Contains(query));


            var movieDtos = moviesQuery
                .ToList()
                .Select(Mapper.Map<Movie, MovieDto>);

            return Ok(movieDtos);
        }
        //Put /api/MovieReturn
        [HttpPut]
        public IHttpActionResult ReturnMovie(RentalDto rentalDto)
        {
            var rentalQuery = _context.Rentals.Include(c => c.Customer).Include(m => m.Movie);

            foreach (var movieId in rentalDto.MovieIds)
            {
                rentalQuery = rentalQuery.Where(c => c.Customer.Id == rentalDto.CustomerId
                                                     && c.Movie.Id == movieId
                                                     && c.DateReturned == null);
                var rental = rentalQuery.First();
                rental.Movie.NumberAvailable++;
                rental.DateReturned = DateTime.Now;
            }

            _context.SaveChanges();
            return Ok();
        }
    }
}
