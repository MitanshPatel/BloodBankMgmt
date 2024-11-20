using BloodBank.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BloodBank.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BloodBankController : ControllerBase
    {
        private static List<BloodBankClass> _bloodBank = new List<BloodBankClass>();
        private static int _id=1;

        [HttpPost]
        public IActionResult Create([FromBody] List<BloodBankClass> bloodBanks)
        {
            foreach (var bloodBank in bloodBanks)
            {
                bloodBank.Id = _id++;
                _bloodBank.Add(bloodBank);
            }
            return Ok(bloodBanks);
        }


        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_bloodBank);
        }

        [HttpGet("{id}", Name = "GetById")]
        public IActionResult GetById(int id)
        {
            var bloodBank= _bloodBank.FirstOrDefault(b => b.Id == id);
            if (bloodBank== null)
            {
                return NotFound();
            }
            return Ok(bloodBank);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] BloodBankClass updatedBloodBank)
        {
            var bloodBank= _bloodBank.FirstOrDefault(b => b.Id == id);
            if (bloodBank == null)
            {
                return NotFound();
            }

            bloodBank.DonorName = updatedBloodBank.DonorName;
            bloodBank.BloodType = updatedBloodBank.BloodType;
            bloodBank.Quantity = updatedBloodBank.Quantity;
            bloodBank.CollectionDate = updatedBloodBank.CollectionDate;
            bloodBank.ExpirationDate = updatedBloodBank.ExpirationDate;
            bloodBank.Status = updatedBloodBank.Status;

            return Ok(bloodBank);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var bloodBank = _bloodBank.FirstOrDefault(b => b.Id == id);
            if (bloodBank == null)
            {
                return NotFound();
            }

            _bloodBank.Remove(bloodBank);
            return NoContent();
        }

        [HttpGet("search")]
        public IActionResult Search([FromQuery] string bloodType="", [FromQuery] string status="", [FromQuery] string donorName="")
        {
            var results = _bloodBank.AsQueryable();

            if (bloodType!="" && !string.IsNullOrEmpty(bloodType))
            {
                results = results.Where(b => b.BloodType == bloodType);
            }

            if (status!="" && !string.IsNullOrEmpty(status))
            {
                results = results.Where(b => b.Status == status);
            }

            if (donorName!="" && !string.IsNullOrEmpty(donorName))
            {
                results = results.Where(b => b.DonorName.Contains(donorName, StringComparison.OrdinalIgnoreCase));
            }

            return Ok(results.ToList());
        }

        [HttpGet("pagination")]
        public IActionResult GetPaginated([FromQuery] int page = 1, [FromQuery] int size = 10)
        {
            var paginatedList = _bloodBank.Skip((page - 1) * size).Take(size).ToList();
            return Ok(paginatedList);
        }
    }
}
