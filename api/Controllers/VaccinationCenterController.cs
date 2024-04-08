using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.Mappers;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{



[Route("api/VaccinationCenter")]

    public class VaccinationCenterController : ControllerBase 
    {
     private readonly ApplicationDBContext _context;

        public VaccinationCenterController(ApplicationDBContext context)
        {
             _context = context;
        }

        [HttpGet]
        public IActionResult GetAll() {
            var VaccinationCenters = _context.VaccinationCenters.ToList().Select(v => v.ToVaccinationCenterDto());
            return Ok(VaccinationCenters);
        }

        [HttpGet("{id}")]
        public IActionResult GetOne( [FromRoute] int id){
            var VaccinationCenter = _context.VaccinationCenters.Find(id);
            if (VaccinationCenter == null)
                return NotFound();
            return Ok(VaccinationCenter.ToVaccinationCenterDto());    
        }
    }
}