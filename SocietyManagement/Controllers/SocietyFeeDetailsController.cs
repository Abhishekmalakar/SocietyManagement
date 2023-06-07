using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SocietyManagement.Models;

namespace SocietyManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocietyFeeDetailsController : ControllerBase
    {
        private readonly SocietyManagementContext _context;

        public SocietyFeeDetailsController(SocietyManagementContext context)
        {
            _context = context;
        }

        // GET: api/SocietyFeeDetails
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SocietyFeeDetail>>> GetSocietyFeeDetail()
        {
            return await _context.SocietyFeeDetail.ToListAsync();
        }

        [HttpGet("getAllDetail")]
        public async Task<ActionResult<IEnumerable<Details>>> GetAllDetail()
        {
            try
            {
                var det = (from sf in _context.SocietyFeeDetail
                           join ud in _context.UserDetails
                           on sf.SocietyId equals ud.SocietyId
                           select new Details()
                           {
                               FirstName = ud.FirstName,
                               LastName = ud.LastName,
                               UserEmail = ud.UserEmail,
                               Contect = ud.Contect,
                               Address = ud.Address,
                               SocietyId = sf.SocietyId,
                               SocietyName = sf.SocietyName,
                               PayAmount = sf.PayAmount,
                               Paydate = sf.Paydate,
                               Modifydate=sf.Modifydate
                           }).ToListAsync() ;
                var Det = await det;
                if (Det.Count > 0)
                {
                    return Ok();
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        // GET: api/SocietyFeeDetails/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SocietyFeeDetail>> GetSocietyFeeDetail(int id)
        {
            var societyFeeDetail = await _context.SocietyFeeDetail.FindAsync(id);

            if (societyFeeDetail == null)
            {
                return NotFound();
            }

            return societyFeeDetail;
        }

        // PUT: api/SocietyFeeDetails/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSocietyFeeDetail(int id, SocietyFeeDetail societyFeeDetail)
        {
            if (id != societyFeeDetail.SocietyId)
            {
                return BadRequest();
            }

            _context.Entry(societyFeeDetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SocietyFeeDetailExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/SocietyFeeDetails
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<SocietyFeeDetail>> PostSocietyFeeDetail(SocietyFeeDetail societyFeeDetail)
        {
            _context.SocietyFeeDetail.Add(societyFeeDetail);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (SocietyFeeDetailExists(societyFeeDetail.SocietyId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetSocietyFeeDetail", new { id = societyFeeDetail.SocietyId }, societyFeeDetail);
        }

        // DELETE: api/SocietyFeeDetails/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<SocietyFeeDetail>> DeleteSocietyFeeDetail(int id)
        {
            var societyFeeDetail = await _context.SocietyFeeDetail.FindAsync(id);
            if (societyFeeDetail == null)
            {
                return NotFound();
            }

            _context.SocietyFeeDetail.Remove(societyFeeDetail);
            await _context.SaveChangesAsync();

            return societyFeeDetail;
        }

        private bool SocietyFeeDetailExists(int id)
        {
            return _context.SocietyFeeDetail.Any(e => e.SocietyId == id);
        }
    }
}
