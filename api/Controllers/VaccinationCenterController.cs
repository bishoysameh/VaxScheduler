using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.Dtos.VaccinationCenter;
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

        [HttpPost]
        public IActionResult Create([FromBody] CreateVaccinationCenterRequestDto VaccinationCenterDto){
            var VaccinationCenterModel = VaccinationCenterDto.ToVaccinationCenterFromCreateDto();
            _context.VaccinationCenters.Add(VaccinationCenterModel);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetOne), new {id = VaccinationCenterModel.Id} ,VaccinationCenterModel.ToVaccinationCenterDto());
        }

        [HttpPut("{id}")]
        public IActionResult Update([FromRoute] int id , [FromBody] UpdateVaccinationCenterRequestDto updateDto){
            var VaccinationCenterModel = _context.VaccinationCenters.FirstOrDefault(v => v.Id == id);
            if(VaccinationCenterModel == null){
                return NotFound();
            }
            VaccinationCenterModel.Name = updateDto.Name;
            VaccinationCenterModel.Address = updateDto.Address;
            VaccinationCenterModel.ContactInfo = updateDto.ContactInfo;   
            VaccinationCenterModel.AdminId = updateDto.AdminId;

            _context.SaveChanges();

            return Ok(VaccinationCenterModel.ToVaccinationCenterDto()); 
        }

        [HttpDelete("{id}")]
        public IActionResult Delete([FromRoute] int id){
            var VaccinationCenterModel = _context.VaccinationCenters.FirstOrDefault(v=>v.Id == id);
            if (VaccinationCenterModel == null)
            {
                return NotFound();
            }
            _context.VaccinationCenters.Remove(VaccinationCenterModel);
            _context.SaveChanges();

            return NoContent();
        }
    }
}