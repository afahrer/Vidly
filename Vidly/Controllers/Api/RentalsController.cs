using AutoMapper;
using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Vidly.Dtos;
using Vidly.Models;

namespace Vidly.Controllers.Api
{
    public class RentalsController : ApiController
    {
        private ApplicationDbContext _context;
        public RentalsController()
        {
            _context = new ApplicationDbContext();
        }
        //GET /api/Rentals
        public IHttpActionResult GetRentals()
        {
            var rentalDto = _context.Rentals               
                .ToList()
                .Select(Mapper.Map<Rental, RentalDto>);
            return Ok(rentalDto);
        }
        // POST /api/Rentals
        [HttpPost]
        public IHttpActionResult CreateRental(RentalDto rentalDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var customer = _context.Customers.Single(c => c.Id == rentalDto.CustomerId);  
                
            foreach (var id in rentalDto.MovieIds)
            {
                var movie = _context.Movies.Single(m => m.Id == id);
                if (movie.NumberAvailable == 0)
                    return BadRequest("Movie is not available");
                movie.NumberAvailable--;
                var rental = new Rental
                {
                    Movie = movie,
                    Customer = customer,
                    DateRented = DateTime.Now
                };
                _context.Rentals.Add(rental);
            }
            _context.SaveChanges();
            return Ok();
        }
        //Put /api/Rentals/id
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
