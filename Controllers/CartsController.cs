using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AuthServer.Context;
using Shared;
using Bogus;

namespace AuthServer.Controllers
{
    public class CartsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CartsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _context.Carts.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Details(int id)
        {
            var cart = await _context.Carts.FirstOrDefaultAsync(m => m.Id == id);

            if (cart == null)
                return NotFound();

            return Ok(cart);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> CreateCart()
        {
            var fakeCart = new Faker<Cart>()
                .RuleFor(c => c.IBAN, f => f.Finance.Iban())
                .RuleFor(c => c.CartNumber, f => f.Random.Replace("#######"))
                .RuleFor(c => c.CVV, f => f.Random.Int(100, 999))
                .RuleFor(c => c.ExpirationDate, f => f.Date.Future(f.Random.Int(5, 10), DateTime.Now))
                .RuleFor(c => c.CartPassword, f => f.Random.Int(1000, 9999))
                .RuleFor(c => c.Debt, f => f.Random.Int(0, 30))
                .RuleFor(c => c.Balance, f => f.Finance.Amount())
                .RuleFor(c => c.Limit, f => f.Finance.Amount() + f.Random.Int(0, 3000))
                .RuleFor(c => c.InternetShop, f => f.Random.Bool());

            var cart = fakeCart.Generate(1);

            _context.Carts.Add(cart[0]);
            await _context.SaveChangesAsync();

            return Ok(cart);
        }
    }
}