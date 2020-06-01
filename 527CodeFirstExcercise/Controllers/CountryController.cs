using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _527CodeFirstExcercise.Context;
using Microsoft.AspNetCore.Mvc;

namespace _527CodeFirstExcercise.Controllers
{
    public class CountryController : Controller
    {
        private readonly CountryContext _context;
        public CountryController(CountryContext context)
        {
            _context = context;
        }

        public IActionResult CountryIndex()
        {
            List<Country> countries = _context.Countries.ToList();
            return View(countries);
        }
    }
}