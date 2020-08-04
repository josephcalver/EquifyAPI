using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EquifyAPI.Models;

namespace EquifyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DealPipelineController : ControllerBase
    {
        private readonly EquifyContext _context;

        public DealPipelineController(EquifyContext context)
        {
            _context = context;
        }
        
        // GET: api/DealPipeline
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Deal>>> GetDeals(string fundInvesting, string dealStatus,
            string region, string sector, string dealType)
        {
            var deals = from d in _context.Deal
                        select d;

            if (!String.IsNullOrEmpty(fundInvesting))
            {
                deals = deals.Where(d => d.FundInvesting.Contains(fundInvesting));
            }
            if (!String.IsNullOrEmpty(dealStatus))
            {
                deals = deals.Where(d => d.DealStatus.Contains(dealStatus));
            }
            if (!String.IsNullOrEmpty(region))
            {
                deals = deals.Where(d => d.Region.Contains(region));
            }
            if (!String.IsNullOrEmpty(sector))
            {
                deals = deals.Where(d => d.Sector.Contains(sector));
            }
            if (!String.IsNullOrEmpty(dealType))
            {
                deals = deals.Where(d => d.DealType.Contains(dealType));
            }

            return await deals.ToListAsync();
        }
       
        // GET: api/DealPipeline/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Deal>> GetDeal(int id)
        {
            var deal = await _context.Deal.FindAsync(id);

            if (deal == null)
            {
                return NotFound();
            }

            return Ok(deal);
        }

        // PUT: api/DealPipeline/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut]
        public async Task<ActionResult<Deal>> PutDeal(Deal deal)
        {
            if (!DealExists(deal.Id))
            {
                return NotFound();
            }
            
            _context.Entry(deal).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return Ok(await _context.Deal.FindAsync(deal.Id));
        }
        

        // POST: api/DealPipeline
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Deal>> PostDeal(Deal deal)
        {
            _context.Deal.Add(deal);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDeal", new { id = deal.Id }, deal);
        }

        // DELETE: api/DealPipeline/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Deal>> DeleteDeal(int id)
        {
            var deal = await _context.Deal.FindAsync(id);
            if (deal == null)
            {
                return NotFound();
            }

            _context.Deal.Remove(deal);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DealExists(int id)
        {
            return _context.Deal.Any(d => d.Id == id);
        }
    }
}
