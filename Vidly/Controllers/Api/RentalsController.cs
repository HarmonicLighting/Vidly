using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
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

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        [HttpGet]
        public IHttpActionResult Index()
        {
            var rentals = _context.Rentals.ToList();
            return Ok(rentals);
        }


        [HttpPost]
        public IHttpActionResult CreateRentals(RentalDTO rental)
        {
            Customer customer = _context.Customers.SingleOrDefault(c => c.Id == rental.CustomerId);
            if (customer == null)
            {
                return BadRequest("The Customer is not valid.");
            }

            if (rental.MovieIds == null || rental.MovieIds.Count == 0)
            {
                return BadRequest("The movies count is 0.");
            }

            var movies = _context.Movies.Where(m => rental.MovieIds.Contains(m.Id)).ToList();

            if (movies.Count != rental.MovieIds.Count)
            {
                return BadRequest("One or more Movies were invalid.");
            }

            var now = DateTime.Now;

            foreach (var movie in movies)
            {

                if (movie.Available <= 0)
                {
                    return BadRequest("The movie "+movie.Name+" doesn't have any availability.");
                }

                movie.Available--;
     
                
                var newRental = new Rental
                {
                    CustomerId = customer.Id,
                    MovieId = movie.Id,
                    RentalDate = now
                };

                _context.Rentals.Add(newRental);
            }

            _context.SaveChanges();

            return Ok();
        }
    }

}
